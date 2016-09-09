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
    public partial class RadFormProveedor : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttProveedor = new DataTable();
        Negocio Consulta = new Negocio();
        int RowIndex = -1;
        public RadFormProveedor()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaProveedor();
            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaProveedor()
        {
            dts = Consulta.ConsultaProveedor();

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {

                var product = from prod in dts.Tables[1].Copy().AsEnumerable()
                              where prod.Field<bool>("Activo") == (Program.User.RolID == 1 ? prod.Field<bool>("Activo") : true)
                              select prod;

                if (product.Count() > 0)
                {
                    dttProveedor = product.CopyToDataTable();
                    ConfiguraGrilla();

                }
                else
                {
                    RadGridViewProveedor.DataSource = new DataTable();
                    RadGridViewProveedor.Columns.Clear();
                }


                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewProveedor.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewProveedors_CurrentRowChanged);

            RadGridViewProveedor.DataSource = new DataTable();
            RadGridViewProveedor.Columns.Clear();

            RadGridViewProveedor.EnableFiltering = true;
            RadGridViewProveedor.AutoGenerateColumns = false;
            RadGridViewProveedor.AllowAddNewRow = false;
            RadGridViewProveedor.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewProveedor.MasterTemplate.ShowFilteringRow = false;
            RadGridViewProveedor.TableElement.EndUpdate();
            RadGridViewProveedor.AllowDeleteRow = false;
            RadGridViewProveedor.AllowRowResize = false;
            RadGridViewProveedor.AllowEditRow = true;
            RadGridViewProveedor.ShowRowHeaderColumn = false;
            RadGridViewProveedor.Select();
            RadGridViewProveedor.EnableSorting = true;

            List<int> data = dttProveedor.AsEnumerable().Select(Nombre => Nombre.Field<string>("Nombre").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttProveedor.AsEnumerable()
                      where dat.Field<string>("Nombre").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colNombre = new GridViewTextBoxColumn();
            colNombre.FieldName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinWidth = Consulta.AnchoTexto(WidthText > colNombre.HeaderText.Length
                                            ? col.First().Field<string>("Nombre").ToString()
                                            : colNombre.HeaderText, RadGridViewProveedor.Font);
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            RadGridViewProveedor.Columns.Add(colNombre);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewProveedor.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewProveedor.Columns.Add(colActivo);

            RadGridViewProveedor.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewProveedors_CurrentRowChanged);

            RadGridViewProveedor.DataSource = dttProveedor;
        }

        private void RadGridViewProveedors_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow == null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.ProveedorID = int.Parse(dtsProveedor.Rows[RowIndex]["ProveedorID"].ToString());
            RadTxtNombre.Text = dttProveedor.Rows[RowIndex]["Nombre"].ToString();
            RadChkActivo.Checked = bool.Parse(dttProveedor.Rows[RowIndex]["Activo"].ToString());
        }

        private void Habilita(bool estado)
        {
            RadTxtNombre.Enabled = estado;
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
            RadGridViewProveedor.Enabled = false;
            RadTxtNombre.Focus();
        }

        private void Limpia()
        {
            RadTxtNombre.Text = "";
            RadChkActivo.Checked = true;
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewProveedor.Enabled = false;
            RadTxtNombre.Focus();
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            bool modifica = RowIndex > -1;

            if (ValidaCambios(modifica))
            {
                RadMessageBox.Show("No se han realizado cambios.", "ALERTA");
                return;
            }

            if(RadMessageBox.Show("Seguro desea guardar la información suministrada?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (RadTxtNombre.Text == "")
            {
                RadMessageBox.Show("Debes ingresar Nombre del Proveedor.", "ALERTA");
                return;
            }

            
            Proveedor Product = new Proveedor();
            Product.ProveedorID = modifica ? int.Parse(dttProveedor.Rows[RowIndex]["ProveedorID"].ToString()) : 0;
            Product.Nombre = RadTxtNombre.Text;
            Product.Activo = RadChkActivo.Checked;

            DataSet dtsSave = Consulta.GuardaProveedor(modifica, Product);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            dts = Consulta.ConsultaProveedor();
            TablaProveedor();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewProveedor.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaProveedor();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewProveedor.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;

            if (modifica)
            {
                cont = RadTxtNombre.Text != dttProveedor.Rows[RowIndex]["Nombre"].ToString() ? (cont + 1) : cont;
                cont = RadChkActivo.Checked != bool.Parse(dttProveedor.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont;
            }

            return modifica ? cont == 0 : modifica;
        }
        
    }
}