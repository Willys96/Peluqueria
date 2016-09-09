using Peluqueria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Peluqueria
{
    public partial class RadFormDeposito : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttDeposito = new DataTable();
        Negocio Consulta = new Negocio();
        int RowIndex = -1;

        public RadFormDeposito()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaDeposito();
            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaDeposito()
        {
            dts = Consulta.ConsultaDeposito("","");

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {

                var product = from prod in dts.Tables[1].Copy().AsEnumerable()
                              where prod.Field<bool>("Activo") == (Program.User.RolID == 1 ? prod.Field<bool>("Activo") : true)
                              select prod;

                if (product.Count() > 0)
                {
                    dttDeposito = product.CopyToDataTable();
                    ConfiguraGrilla();

                }
                else
                {
                    RadGridViewDeposito.DataSource = new DataTable();
                    RadGridViewDeposito.Columns.Clear();
                }


                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewDeposito.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewDepositos_CurrentRowChanged);

            RadGridViewDeposito.DataSource = new DataTable();
            RadGridViewDeposito.Columns.Clear();

            RadGridViewDeposito.EnableFiltering = true;
            RadGridViewDeposito.AutoGenerateColumns = false;
            RadGridViewDeposito.AllowAddNewRow = false;
            RadGridViewDeposito.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewDeposito.MasterTemplate.ShowFilteringRow = false;
            RadGridViewDeposito.TableElement.EndUpdate();
            RadGridViewDeposito.AllowDeleteRow = false;
            RadGridViewDeposito.AllowRowResize = false;
            RadGridViewDeposito.AllowEditRow = true;
            RadGridViewDeposito.ShowRowHeaderColumn = false;
            RadGridViewDeposito.Select();
            RadGridViewDeposito.EnableSorting = true;

            List<int> data = dttDeposito.AsEnumerable().Select(Nombre => Nombre.Field<int>("ValorDeposito").ToString().Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttDeposito.AsEnumerable()
                  where dat.Field<string>("ValorDeposito").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colValorDeposito = new GridViewTextBoxColumn();
            colValorDeposito.DataType = typeof(decimal);
            colValorDeposito.FieldName = "ValorDeposito";
            colValorDeposito.FormatString = "{0:C}";
            colValorDeposito.HeaderText = "Valor de Deposito";
            colValorDeposito.MinWidth = Consulta.AnchoTexto(WidthText > colValorDeposito.HeaderText.Length
                                            ? col.First().Field<int>("ValorDeposito").ToString()
                                            : colValorDeposito.HeaderText, RadGridViewDeposito.Font);
            colValorDeposito.Name = "colValorDeposito";
            colValorDeposito.ReadOnly = true;
            RadGridViewDeposito.Columns.Add(colValorDeposito);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewDeposito.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewDeposito.Columns.Add(colActivo);

            RadGridViewDeposito.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewDepositos_CurrentRowChanged);

            RadGridViewDeposito.DataSource = dttDeposito;
        }

        private void RadGridViewDepositos_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow == null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.DepositoID = int.Parse(dtsDeposito.Rows[RowIndex]["DepositoID"].ToString());
            RadMskValorDeposito.Text = dttDeposito.Rows[RowIndex]["ValorDeposito"].ToString();
            RadChkActivo.Checked = bool.Parse(dttDeposito.Rows[RowIndex]["Activo"].ToString());
        }

        private void Habilita(bool estado)
        {
            RadMskValorDeposito.Enabled = estado;
            RadChkActivo.Enabled = estado;
        }

        private void RadMenuItemAdicionar_Click(object sender, EventArgs e)
        {
            RowIndex = -1;
            Limpia();
            Habilita(true);
            RadChkActivo.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewDeposito.Enabled = false;
            RadMskValorDeposito.Focus();
        }

        private void Limpia()
        {
            RadMskValorDeposito.Value = "";
            RadChkActivo.Checked = true;
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewDeposito.Enabled = false;
            RadMskValorDeposito.Focus();
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            bool modifica = RowIndex > -1;

            if (ValidaCambios(modifica))
            {
                RadMessageBox.Show("No se han realizado cambios.", "ALERTA");
                return;
            }

            if (RadMessageBox.Show("Seguro desea guardar la información suministrada?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }           

            if (float.Parse(RadMskValorDeposito.Value.ToString()) == 0)
            {
                RadMessageBox.Show("Debes ingresar el valor del Deposito", "ALERTA");
                return;
            }

            Deposito Product = new Deposito();
            Product.DepositoID = modifica ? int.Parse(dttDeposito.Rows[RowIndex]["DepositoID"].ToString()) : 0;
            Product.ValorDeposito = Convert.ToInt32(float.Parse(RadMskValorDeposito.Value.ToString()));
            Product.Activo = RadChkActivo.Checked;

            DataSet dtsSave = Consulta.GuardaDeposito(modifica, Product);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            TablaDeposito();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewDeposito.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaDeposito();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewDeposito.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;

            if (modifica)
            {
                cont = float.Parse(RadMskValorDeposito.Value.ToString()) != float.Parse(dttDeposito.Rows[RowIndex]["ValorDeposito"].ToString()) ? (cont + 1) : cont;
                cont = RadChkActivo.Checked != bool.Parse(dttDeposito.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont;
            }

            return modifica ? cont == 0 : modifica;
        }

    }
}