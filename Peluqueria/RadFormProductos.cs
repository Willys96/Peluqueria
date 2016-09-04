using Peluqueria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Peluqueria
{
    public partial class RadFormProductos : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttProducto = new DataTable();
        Negocio Consulta = new Negocio();

        int RowIndex = -1;
        public RadFormProductos()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaProducto();
            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaProducto()
        {
            dts = Consulta.ConsultaProducto();

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
                    dttProducto = product.CopyToDataTable();
                    ConfiguraGrilla();

                }
                else
                {
                    RadGridViewProductos.DataSource = new DataTable();
                    RadGridViewProductos.Columns.Clear();
                }


                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewProductos.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewProductos_CurrentRowChanged);

            RadGridViewProductos.DataSource = new DataTable();
            RadGridViewProductos.Columns.Clear();

            RadGridViewProductos.EnableFiltering = true;
            RadGridViewProductos.AutoGenerateColumns = false;
            RadGridViewProductos.AllowAddNewRow = false;
            RadGridViewProductos.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewProductos.MasterTemplate.ShowFilteringRow = false;
            RadGridViewProductos.TableElement.EndUpdate();
            RadGridViewProductos.AllowDeleteRow = false;
            RadGridViewProductos.AllowRowResize = false;
            RadGridViewProductos.AllowEditRow = true;
            RadGridViewProductos.ShowRowHeaderColumn = false;
            RadGridViewProductos.Select();
            RadGridViewProductos.EnableSorting = true;

            List<int> data = dttProducto.AsEnumerable().Select(Nombre => Nombre.Field<string>("Nombre").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttProducto.AsEnumerable()
                      where dat.Field<string>("Nombre").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colNombre = new GridViewTextBoxColumn();
            colNombre.FieldName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinWidth = Consulta.AnchoTexto(WidthText > colNombre.HeaderText.Length
                                            ? col.First().Field<string>("Nombre").ToString()
                                            : colNombre.HeaderText, RadGridViewProductos.Font);
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colNombre);

            data = dttProducto.AsEnumerable().Select(CodigoProducto => CodigoProducto.Field<string>("CodigoProducto").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttProducto.AsEnumerable()
                      where dat.Field<string>("CodigoProducto").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colCodigoProducto = new GridViewTextBoxColumn();
            colCodigoProducto.FieldName = "CodigoProducto";
            colCodigoProducto.HeaderText = "Codigo";
            colCodigoProducto.MinWidth = Consulta.AnchoTexto(WidthText > colCodigoProducto.HeaderText.Length
                                            ? col.First().Field<string>("CodigoProducto").ToString()
                                            : colCodigoProducto.HeaderText, RadGridViewProductos.Font);
            colCodigoProducto.Name = "colCodigoProducto";
            colCodigoProducto.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colCodigoProducto);

            data = dttProducto.AsEnumerable().Select(Proveedor => Proveedor.Field<string>("Proveedor").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttProducto.AsEnumerable()
                  where dat.Field<string>("Proveedor").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colProveedor = new GridViewTextBoxColumn();
            colProveedor.FieldName = "Proveedor";
            colProveedor.HeaderText = "Proveedor";
            colProveedor.MinWidth = Consulta.AnchoTexto(WidthText > colProveedor.HeaderText.Length
                                            ? col.First().Field<string>("Proveedor").ToString()
                                            : colProveedor.HeaderText, RadGridViewProductos.Font);
            colProveedor.Name = "colProveedor";
            colProveedor.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colProveedor);

            data = dttProducto.AsEnumerable().Select(Nombre => Nombre.Field<int>("UnidadxProducto").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttProducto.AsEnumerable()
                  where dat.Field<string>("UnidadxProducto").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colUnidadxProducto = new GridViewTextBoxColumn();
            colUnidadxProducto.DataType = typeof(decimal);
            colUnidadxProducto.FieldName = "UnidadxProducto";
            colUnidadxProducto.FormatString = "{0:G}";
            colUnidadxProducto.HeaderText = "Unidad por Producto";
            colUnidadxProducto.MinWidth = Consulta.AnchoTexto(WidthText > colUnidadxProducto.HeaderText.Length
                                            ? col.First().Field<int>("UnidadxProducto").ToString()
                                            : colUnidadxProducto.HeaderText, RadGridViewProductos.Font);
            colUnidadxProducto.Name = "colUnidadxProducto";
            colUnidadxProducto.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colUnidadxProducto);

            data = dttProducto.AsEnumerable().Select(Nombre => Nombre.Field<int>("ValorCompra").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttProducto.AsEnumerable()
                  where dat.Field<string>("ValorCompra").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colValorCompra = new GridViewTextBoxColumn();
            colValorCompra.DataType = typeof(decimal);
            colValorCompra.FieldName = "ValorCompra";
            colValorCompra.FormatString="{0:C}";
            colValorCompra.HeaderText = "Valor de Compra";
            colValorCompra.MinWidth = Consulta.AnchoTexto(WidthText > colValorCompra.HeaderText.Length
                                            ? col.First().Field<int>("ValorCompra").ToString()
                                            : colValorCompra.HeaderText, RadGridViewProductos.Font);
            colValorCompra.Name = "colValorCompra";
            colValorCompra.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colValorCompra);

            data = dttProducto.AsEnumerable().Select(Nombre => Nombre.Field<int>("ValorVentaXUnidad").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttProducto.AsEnumerable()
                  where dat.Field<string>("ValorVentaXUnidad").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colValorVentaXUnidad = new GridViewTextBoxColumn();
            colValorVentaXUnidad.DataType = typeof(decimal);
            colValorVentaXUnidad.FieldName = "ValorVentaXUnidad";
            colValorVentaXUnidad.FormatString = "{0:C}";
            colValorVentaXUnidad.HeaderText = "Valor de Venta Unidad";
            colValorVentaXUnidad.MinWidth = Consulta.AnchoTexto(WidthText > colValorVentaXUnidad.HeaderText.Length
                                            ? col.First().Field<int>("ValorVentaXUnidad").ToString()
                                            : colValorVentaXUnidad.HeaderText, RadGridViewProductos.Font);
            colValorVentaXUnidad.Name = "colValorVentaXUnidad";
            colValorVentaXUnidad.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colValorVentaXUnidad);

            data = dttProducto.AsEnumerable().Select(Nombre => Nombre.Field<int>("PorcentajeVentaPublico").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttProducto.AsEnumerable()
                  where dat.Field<string>("PorcentajeVentaPublico").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colPorcentajeVentaPublico = new GridViewTextBoxColumn();
            colPorcentajeVentaPublico.DataType = typeof(decimal);
            colPorcentajeVentaPublico.FieldName = "PorcentajeVentaPublico";
            colPorcentajeVentaPublico.FormatString = "{0:G}";
            colPorcentajeVentaPublico.HeaderText = "Porcentaje de Bonificación";
            colPorcentajeVentaPublico.MinWidth = Consulta.AnchoTexto(WidthText > colPorcentajeVentaPublico.HeaderText.Length
                                            ? col.First().Field<int>("PorcentajeVentaPublico").ToString()
                                            : colPorcentajeVentaPublico.HeaderText, RadGridViewProductos.Font);
            colPorcentajeVentaPublico.Name = "colPorcentajeVentaPublico";
            colPorcentajeVentaPublico.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colPorcentajeVentaPublico);

            data = dttProducto.AsEnumerable().Select(Nombre => Nombre.Field<int>("DescuentoVentaInterna").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttProducto.AsEnumerable()
                  where dat.Field<string>("DescuentoVentaInterna").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colDescuentoVentaInterna = new GridViewTextBoxColumn();
            colDescuentoVentaInterna.DataType = typeof(decimal);
            colDescuentoVentaInterna.FieldName = "DescuentoVentaInterna";
            colDescuentoVentaInterna.FormatString = "{0:G}";
            colDescuentoVentaInterna.HeaderText = "Unidad por Producto";
            colDescuentoVentaInterna.MinWidth = Consulta.AnchoTexto(WidthText > colDescuentoVentaInterna.HeaderText.Length
                                            ? col.First().Field<int>("DescuentoVentaInterna").ToString()
                                            : colDescuentoVentaInterna.HeaderText, RadGridViewProductos.Font);
            colDescuentoVentaInterna.Name = "colDescuentoVentaInterna";
            colDescuentoVentaInterna.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colDescuentoVentaInterna);

            GridViewCheckBoxColumn colInsumo = new GridViewCheckBoxColumn();
            colInsumo.FieldName = "Insumo";
            colInsumo.HeaderText = "Insumo";
            colInsumo.MinWidth = Consulta.AnchoTexto("Insumo", RadGridViewProductos.Font);
            colInsumo.Name = "colInsumo";
            colInsumo.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colInsumo);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewProductos.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewProductos.Columns.Add(colActivo);

            RadGridViewProductos.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewProductos_CurrentRowChanged);

            RadGridViewProductos.DataSource = dttProducto;
        }

        private void RadGridViewProductos_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow ==null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.ProductoID = int.Parse(dtsProducto.Rows[RowIndex]["ProductoID"].ToString());
            RadChkInsumo.Checked = bool.Parse(dttProducto.Rows[RowIndex]["Insumo"].ToString());
            RadTxtNombre.Text = dttProducto.Rows[RowIndex]["Nombre"].ToString();
            RadTxtCodigo.Text = dttProducto.Rows[RowIndex]["CodigoProducto"].ToString();
            RadMskUnidadProducto.Text = dttProducto.Rows[RowIndex]["UnidadxProducto"].ToString();
            RadMskValorCompra.Text = dttProducto.Rows[RowIndex]["ValorCompra"].ToString();
            RadMskValorUnidadVenta.Text = dttProducto.Rows[RowIndex]["ValorVentaXUnidad"].ToString();
            RadMskPorcentaje.Text = dttProducto.Rows[RowIndex]["PorcentajeVentaPublico"].ToString();
            RadMskDescuento.Text = dttProducto.Rows[RowIndex]["DescuentoVentaInterna"].ToString();
            RadChkActivo.Checked = bool.Parse(dttProducto.Rows[RowIndex]["Activo"].ToString());
            RadDrpProveedor.SelectedValue= int.Parse(dttProducto.Rows[RowIndex]["ProveedorID"].ToString());
        }

        private void Habilita(bool estado)
        {
            RadTxtNombre.Enabled = estado;
            RadMskUnidadProducto.Enabled = estado;
            RadMskValorCompra.Enabled = estado;
            RadMskValorUnidadVenta.Enabled = estado;
            RadChkActivo.Enabled = estado;
            RadMskDescuento.Enabled = estado;
            RadMskPorcentaje.Enabled = estado;
            RadChkInsumo.Enabled = estado;
            RadTxtCodigo.Enabled = estado;
            RadDrpProveedor.Enabled = estado;
        }

        private void RadMenuItemAdicionar_Click(object sender, EventArgs e)
        {
            Limpia();
            Habilita(true);
            RadChkActivo.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewProductos.Enabled = false;
            RadTxtNombre.Focus();
        }

        private void Limpia()
        {
            RadTxtNombre.Text = "";
            RadMskUnidadProducto.Value = "";
            RadMskValorCompra.Value = "";
            RadMskValorUnidadVenta.Value = "";
            RadChkActivo.Checked = true;
            RadMskDescuento.Value = "";
            RadMskPorcentaje.Value = "";
            RadChkInsumo.Checked = false;
            RadTxtCodigo.Text = "";
            RadDrpProveedor.SelectedIndex = -1;
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewProductos.Enabled = false;
            RadTxtNombre.Focus();
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            bool modifica = RadMenuItemEditar.Enabled;

            if (ValidaCambios(modifica))
            {
                RadMessageBox.Show("No se han realizado cambios.", "ALERTA");
                return;
            }

            Producto Product = new Producto();
            Product.ProductoID = modifica ? int.Parse(dttProducto.Rows[RowIndex]["ProductoID"].ToString()) : 0;
            Product.Nombre = RadTxtNombre.Text;
            Product.CodigoProducto = RadTxtCodigo.Text;
            Product.UnidadxProducto = Convert.ToInt32(float.Parse(RadMskUnidadProducto.Value.ToString()));
            Product.ValorCompra = Convert.ToInt32(float.Parse(RadMskValorCompra.Value.ToString()));
            Product.ValorVentaXUnidad = Convert.ToInt32(float.Parse(RadMskValorUnidadVenta.Value.ToString()));
            Product.PorcentajeVentaPublico = Convert.ToInt32(float.Parse(RadMskPorcentaje.Value.ToString())*100);
            Product.DescuentoVentaInterna = Convert.ToInt32(float.Parse(RadMskDescuento.Value.ToString())*100);
            Product.Insumo = RadChkInsumo.Checked;
            Product.Activo = RadChkActivo.Checked;
            Product.ProveedorID = RadDrpProveedor.SelectedIndex>-1? int.Parse(RadDrpProveedor.SelectedValue.ToString()) : 0;

            DataSet dtsSave = Consulta.GuardaProducto(modifica, Product);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            dts = Consulta.ConsultaProducto();
            TablaProducto();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewProductos.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaProducto();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewProductos.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;

            if (modifica)
            {
                cont = RadTxtNombre.Text != dttProducto.Rows[RowIndex]["Nombre"].ToString() ? (cont + 1) : cont;
                cont = RadTxtCodigo.Text != dttProducto.Rows[RowIndex]["CodigoProducto"].ToString() ? (cont + 1) : cont;
                cont = RadMskUnidadProducto.Value.ToString() != dttProducto.Rows[RowIndex]["UnidadxProducto"].ToString() ? (cont + 1) : cont;

                cont = float.Parse(RadMskPorcentaje.Value.ToString())*100 != float.Parse(dttProducto.Rows[RowIndex]["PorcentajeVentaPublico"].ToString()) ? (cont + 1) : cont;
                cont = float.Parse(RadMskDescuento.Value.ToString())*100 != float.Parse(dttProducto.Rows[RowIndex]["DescuentoVentaInterna"].ToString()) ? (cont + 1) : cont;

                cont = float.Parse(RadMskValorCompra.Value.ToString()) !=float.Parse( dttProducto.Rows[RowIndex]["ValorCompra"].ToString()) ? (cont + 1) : cont;
                cont = float.Parse(RadMskValorUnidadVenta.Value.ToString()) != float.Parse(dttProducto.Rows[RowIndex]["ValorVentaXUnidad"].ToString()) ? (cont + 1) : cont;

                cont = RadChkInsumo.Checked != bool.Parse(dttProducto.Rows[RowIndex]["insumo"].ToString()) ? (cont + 1) : cont;

                cont = RadChkActivo.Checked != bool.Parse(dttProducto.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont;

                cont = RadDrpProveedor.SelectedIndex>-1 ?int.Parse(RadDrpProveedor.SelectedValue.ToString()) : 0 
                    != int.Parse(dttProducto.Rows[RowIndex]["ProveedorID"].ToString()) ? (cont + 1) : cont;
            }

            return modifica ? cont == 0 : modifica;
        }

        private void RadChkInsumo_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (RadChkInsumo.Checked)
            {
                RadMskDescuento.Value = "";
                RadMskPorcentaje.Value = "";
            }
        }
    }
}