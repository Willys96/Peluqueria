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
    public partial class RadFormPagoFactura : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttPagoFactura = new DataTable();
        Negocio Consulta = new Negocio();
        int RowIndex = -1;

        public RadFormPagoFactura()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaPagoFactura();
            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaPagoFactura()
        {
            dts = Consulta.ConsultaPagoFactura("","");

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {
                RadDrpProveedor.DataSource = dts.Tables[2];
                RadDrpProveedor.DisplayMember = "Nombre";
                RadDrpProveedor.ValueMember = "ProveedorID";
                RadDrpProveedor.SelectedIndex = -1;

                var product = from prod in dts.Tables[1].Copy().AsEnumerable()
                              where prod.Field<bool>("Activo") == (Program.User.RolID == 1 ? prod.Field<bool>("Activo") : true)
                              select prod;

                if (product.Count() > 0)
                {
                    dttPagoFactura = product.CopyToDataTable();
                    ConfiguraGrilla();

                }
                else
                {
                    RadGridViewPagoFacturas.DataSource = new DataTable();
                    RadGridViewPagoFacturas.Columns.Clear();
                }


                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewPagoFacturas.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewPagoFacturas_CurrentRowChanged);

            RadGridViewPagoFacturas.DataSource = new DataTable();
            RadGridViewPagoFacturas.Columns.Clear();

            RadGridViewPagoFacturas.EnableFiltering = true;
            RadGridViewPagoFacturas.AutoGenerateColumns = false;
            RadGridViewPagoFacturas.AllowAddNewRow = false;
            RadGridViewPagoFacturas.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewPagoFacturas.MasterTemplate.ShowFilteringRow = false;
            RadGridViewPagoFacturas.TableElement.EndUpdate();
            RadGridViewPagoFacturas.AllowDeleteRow = false;
            RadGridViewPagoFacturas.AllowRowResize = false;
            RadGridViewPagoFacturas.AllowEditRow = true;
            RadGridViewPagoFacturas.ShowRowHeaderColumn = false;
            RadGridViewPagoFacturas.Select();
            RadGridViewPagoFacturas.EnableSorting = true;

            List<int> data = dttPagoFactura.AsEnumerable().Select(NumeroFactura => NumeroFactura.Field<string>("NumeroFactura").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttPagoFactura.AsEnumerable()
                      where dat.Field<string>("NumeroFactura").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colNumeroFactura = new GridViewTextBoxColumn();
            colNumeroFactura.FieldName = "NumeroFactura";
            colNumeroFactura.HeaderText = "NumeroFactura";
            colNumeroFactura.MinWidth = Consulta.AnchoTexto(WidthText > colNumeroFactura.HeaderText.Length
                                            ? col.First().Field<string>("NumeroFactura").ToString()
                                            : colNumeroFactura.HeaderText, RadGridViewPagoFacturas.Font);
            colNumeroFactura.Name = "colNumeroFactura";
            colNumeroFactura.ReadOnly = true;
            RadGridViewPagoFacturas.Columns.Add(colNumeroFactura);

            data = dttPagoFactura.AsEnumerable().Select(Proveedor => Proveedor.Field<string>("Proveedor").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttPagoFactura.AsEnumerable()
                  where dat.Field<string>("Proveedor").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colProveedor = new GridViewTextBoxColumn();
            colProveedor.FieldName = "Proveedor";
            colProveedor.HeaderText = "Proveedor";
            colProveedor.MinWidth = Consulta.AnchoTexto(WidthText > colProveedor.HeaderText.Length
                                            ? col.First().Field<string>("Proveedor").ToString()
                                            : colProveedor.HeaderText, RadGridViewPagoFacturas.Font);
            colProveedor.Name = "colProveedor";
            colProveedor.ReadOnly = true;
            RadGridViewPagoFacturas.Columns.Add(colProveedor);

            data = dttPagoFactura.AsEnumerable().Select(Nombre => Nombre.Field<int>("ValorPagoFactura").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttPagoFactura.AsEnumerable()
                  where dat.Field<string>("ValorPagoFactura").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colValorPagoFactura = new GridViewTextBoxColumn();
            colValorPagoFactura.DataType = typeof(decimal);
            colValorPagoFactura.FieldName = "ValorPagoFactura";
            colValorPagoFactura.FormatString = "{0:C}";
            colValorPagoFactura.HeaderText = "Valor de PagoFactura";
            colValorPagoFactura.MinWidth = Consulta.AnchoTexto(WidthText > colValorPagoFactura.HeaderText.Length
                                            ? col.First().Field<int>("ValorPagoFactura").ToString()
                                            : colValorPagoFactura.HeaderText, RadGridViewPagoFacturas.Font);
            colValorPagoFactura.Name = "colValorPagoFactura";
            colValorPagoFactura.ReadOnly = true;
            RadGridViewPagoFacturas.Columns.Add(colValorPagoFactura);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewPagoFacturas.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewPagoFacturas.Columns.Add(colActivo);

            RadGridViewPagoFacturas.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewPagoFacturas_CurrentRowChanged);

            RadGridViewPagoFacturas.DataSource = dttPagoFactura;
        }

        private void RadGridViewPagoFacturas_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow == null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.PagoFacturaID = int.Parse(dtsPagoFactura.Rows[RowIndex]["PagoFacturaID"].ToString());
            RadTxtNumeroFactura.Text = dttPagoFactura.Rows[RowIndex]["NumeroFactura"].ToString();
            RadMskValorPagoFactura.Text = dttPagoFactura.Rows[RowIndex]["ValorPagoFactura"].ToString();
            RadChkActivo.Checked = bool.Parse(dttPagoFactura.Rows[RowIndex]["Activo"].ToString());
            RadDrpProveedor.SelectedValue = int.Parse(dttPagoFactura.Rows[RowIndex]["ProveedorID"].ToString());
        }

        private void Habilita(bool estado)
        {
            RadTxtNumeroFactura.Enabled = estado;
            RadMskValorPagoFactura.Enabled = estado;
            RadChkActivo.Enabled = estado;
            RadDrpProveedor.Enabled = estado;
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
            RadGridViewPagoFacturas.Enabled = false;
            RadTxtNumeroFactura.Focus();
        }

        private void Limpia()
        {
            RadTxtNumeroFactura.Text = "";
            RadMskValorPagoFactura.Value = "";
            RadChkActivo.Checked = true;
            RadDrpProveedor.SelectedIndex = -1;
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewPagoFacturas.Enabled = false;
            RadTxtNumeroFactura.Focus();
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            bool modifica = RowIndex > -1;

            if (ValidaCambios(modifica))
            {
                RadMessageBox.Show("No se han realizado cambios.", "ALERTA");
                return;
            }

            PagoFactura Product = new PagoFactura();
            Product.PagoFacturaID = modifica ? int.Parse(dttPagoFactura.Rows[RowIndex]["PagoFacturaID"].ToString()) : 0;
            Product.NumeroFactura= RadTxtNumeroFactura.Text;
            Product.ValorPagoFactura = Convert.ToInt32(float.Parse(RadMskValorPagoFactura.Value.ToString()));
            Product.Activo = RadChkActivo.Checked;
            Product.ProveedorID = RadDrpProveedor.SelectedIndex > -1 ? int.Parse(RadDrpProveedor.SelectedValue.ToString()) : 0;

            DataSet dtsSave = Consulta.GuardaPagoFactura(modifica, Product);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            TablaPagoFactura();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewPagoFacturas.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaPagoFactura();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewPagoFacturas.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;

            if (modifica)
            {
                cont = RadTxtNumeroFactura.Text != dttPagoFactura.Rows[RowIndex]["NumeroFactura"].ToString() ? (cont + 1) : cont;
                cont = float.Parse(RadMskValorPagoFactura.Value.ToString()) != float.Parse(dttPagoFactura.Rows[RowIndex]["ValorPagoFactura"].ToString()) ? (cont + 1) : cont;
                cont = RadChkActivo.Checked != bool.Parse(dttPagoFactura.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont;
                cont = RadDrpProveedor.SelectedIndex > -1 ? int.Parse(RadDrpProveedor.SelectedValue.ToString()) : 0
                    != int.Parse(dttPagoFactura.Rows[RowIndex]["ProveedorID"].ToString()) ? (cont + 1) : cont;
            }

            return modifica ? cont == 0 : modifica;
        }
        
    }
}