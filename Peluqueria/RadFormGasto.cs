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
    public partial class RadFormGasto : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttGasto = new DataTable();
        Negocio Consulta = new Negocio();
        int RowIndex = -1;

        public RadFormGasto()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaGasto();
            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaGasto()
        {
            dts = Consulta.ConsultaGasto("","");

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {
                var product = from prod in dts.Tables[1].Copy().AsEnumerable()
                              where prod.Field<bool>("Activo") == (Program.User.RolID == 1 ? prod.Field<bool>("Activo") : true)
                              select prod;

                if (product.Count() > 0)
                {
                    dttGasto = product.CopyToDataTable();
                    ConfiguraGrilla();

                }
                else
                {
                    RadGridViewGasto.DataSource = new DataTable();
                    RadGridViewGasto.Columns.Clear();
                }


                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewGasto.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewGastos_CurrentRowChanged);

            RadGridViewGasto.DataSource = new DataTable();
            RadGridViewGasto.Columns.Clear();

            RadGridViewGasto.EnableFiltering = true;
            RadGridViewGasto.AutoGenerateColumns = false;
            RadGridViewGasto.AllowAddNewRow = false;
            RadGridViewGasto.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewGasto.MasterTemplate.ShowFilteringRow = false;
            RadGridViewGasto.TableElement.EndUpdate();
            RadGridViewGasto.AllowDeleteRow = false;
            RadGridViewGasto.AllowRowResize = false;
            RadGridViewGasto.AllowEditRow = true;
            RadGridViewGasto.ShowRowHeaderColumn = false;
            RadGridViewGasto.Select();
            RadGridViewGasto.EnableSorting = true;

            List<int> data = dttGasto.AsEnumerable().Select(Detalle => Detalle.Field<string>("Detalle").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttGasto.AsEnumerable()
                      where dat.Field<string>("Detalle").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colDetalle = new GridViewTextBoxColumn();
            colDetalle.FieldName = "Detalle";
            colDetalle.HeaderText = "Detalle";
            colDetalle.MinWidth = Consulta.AnchoTexto(WidthText > colDetalle.HeaderText.Length
                                            ? col.First().Field<string>("Detalle").ToString()
                                            : colDetalle.HeaderText, RadGridViewGasto.Font);
            colDetalle.Name = "colDetalle";
            colDetalle.ReadOnly = true;
            RadGridViewGasto.Columns.Add(colDetalle);

            data = dttGasto.AsEnumerable().Select(Nombre => Nombre.Field<int>("ValorGasto").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttGasto.AsEnumerable()
                  where dat.Field<string>("ValorGasto").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colValorGasto = new GridViewTextBoxColumn();
            colValorGasto.DataType = typeof(decimal);
            colValorGasto.FieldName = "ValorGasto";
            colValorGasto.FormatString = "{0:C}";
            colValorGasto.HeaderText = "Valor de Gasto";
            colValorGasto.MinWidth = Consulta.AnchoTexto(WidthText > colValorGasto.HeaderText.Length
                                            ? col.First().Field<int>("ValorGasto").ToString()
                                            : colValorGasto.HeaderText, RadGridViewGasto.Font);
            colValorGasto.Name = "colValorGasto";
            colValorGasto.ReadOnly = true;
            RadGridViewGasto.Columns.Add(colValorGasto);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewGasto.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewGasto.Columns.Add(colActivo);

            RadGridViewGasto.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewGastos_CurrentRowChanged);

            RadGridViewGasto.DataSource = dttGasto;
        }

        private void RadGridViewGastos_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow == null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.GastoID = int.Parse(dtsGasto.Rows[RowIndex]["GastoID"].ToString());
            RadTxtDetalle.Text = dttGasto.Rows[RowIndex]["Detalle"].ToString();
            RadMskValorGasto.Text = dttGasto.Rows[RowIndex]["ValorGasto"].ToString();
            RadChkActivo.Checked = bool.Parse(dttGasto.Rows[RowIndex]["Activo"].ToString());
        }

        private void Habilita(bool estado)
        {
            RadTxtDetalle.Enabled = estado;
            RadMskValorGasto.Enabled = estado;
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
            RadGridViewGasto.Enabled = false;
            RadTxtDetalle.Focus();
        }

        private void Limpia()
        {
            RadTxtDetalle.Text = "";
            RadMskValorGasto.Value = "";
            RadChkActivo.Checked = true;
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewGasto.Enabled = false;
            RadTxtDetalle.Focus();
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            bool modifica = RowIndex > -1;

            if (ValidaCambios(modifica))
            {
                RadMessageBox.Show("No se han realizado cambios.", "ALERTA");
                return;
            }

            Gasto Product = new Gasto();
            Product.GastoID = modifica ? int.Parse(dttGasto.Rows[RowIndex]["GastoID"].ToString()) : 0;
            Product.Detalle = RadTxtDetalle.Text;
            Product.ValorGasto = Convert.ToInt32(float.Parse(RadMskValorGasto.Value.ToString()));
            Product.Activo = RadChkActivo.Checked;

            DataSet dtsSave = Consulta.GuardaGasto(modifica, Product);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            TablaGasto();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewGasto.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaGasto();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewGasto.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;

            if (modifica)
            {
                cont = RadTxtDetalle.Text != dttGasto.Rows[RowIndex]["Detalle"].ToString() ? (cont + 1) : cont;
                cont = float.Parse(RadMskValorGasto.Value.ToString()) != float.Parse(dttGasto.Rows[RowIndex]["ValorGasto"].ToString()) ? (cont + 1) : cont;
                cont = RadChkActivo.Checked != bool.Parse(dttGasto.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont;
            }

            return modifica ? cont == 0 : modifica;
        }

    }
}