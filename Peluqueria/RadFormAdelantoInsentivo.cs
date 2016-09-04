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
    public partial class RadFormAdelantoInsentivo : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttAdelantoInsentivo = new DataTable();
        Negocio Consulta = new Negocio();

        int RowIndex = -1;
        public RadFormAdelantoInsentivo()
        {
            InitializeComponent(); ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaAdelantoInsentivo();
            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaAdelantoInsentivo()
        {
            dts = Consulta.ConsultaAdelantoInsentivo("","");

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {
                RadDrpUsuario.DataSource = dts.Tables[2];
                RadDrpUsuario.DisplayMember = "CodigoUsuario";
                RadDrpUsuario.ValueMember = "UsuarioID";
                RadDrpUsuario.SelectedIndex = -1;

                var Adelanto = from prod in dts.Tables[1].Copy().AsEnumerable()
                              where prod.Field<bool>("Activo") == (Program.User.RolID == 1 ? prod.Field<bool>("Activo") : true)
                              select prod;

                if (Adelanto.Count() > 0)
                {
                    dttAdelantoInsentivo = Adelanto.CopyToDataTable();
                    ConfiguraGrilla();

                }
                else
                {
                    RadGridViewAdelantoInsentivos.DataSource = new DataTable();
                    RadGridViewAdelantoInsentivos.Columns.Clear();
                }


                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewAdelantoInsentivos.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewAdelantoInsentivos_CurrentRowChanged);

            RadGridViewAdelantoInsentivos.DataSource = new DataTable();
            RadGridViewAdelantoInsentivos.Columns.Clear();

            RadGridViewAdelantoInsentivos.EnableFiltering = true;
            RadGridViewAdelantoInsentivos.AutoGenerateColumns = false;
            RadGridViewAdelantoInsentivos.AllowAddNewRow = false;
            RadGridViewAdelantoInsentivos.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewAdelantoInsentivos.MasterTemplate.ShowFilteringRow = false;
            RadGridViewAdelantoInsentivos.TableElement.EndUpdate();
            RadGridViewAdelantoInsentivos.AllowDeleteRow = false;
            RadGridViewAdelantoInsentivos.AllowRowResize = false;
            RadGridViewAdelantoInsentivos.AllowEditRow = true;
            RadGridViewAdelantoInsentivos.ShowRowHeaderColumn = false;
            RadGridViewAdelantoInsentivos.Select();
            RadGridViewAdelantoInsentivos.EnableSorting = true;

            List<int> data = dttAdelantoInsentivo.AsEnumerable().Select(Nombre => Nombre.Field<string>("Nombre").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttAdelantoInsentivo.AsEnumerable()
                      where dat.Field<string>("Nombre").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colNombre = new GridViewTextBoxColumn();
            colNombre.FieldName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinWidth = Consulta.AnchoTexto(WidthText > colNombre.HeaderText.Length
                                            ? col.First().Field<string>("Nombre").ToString()
                                            : colNombre.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colNombre);

            data = dttAdelantoInsentivo.AsEnumerable().Select(CodigoAdelantoInsentivo => CodigoAdelantoInsentivo.Field<string>("CodigoAdelantoInsentivo").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttAdelantoInsentivo.AsEnumerable()
                  where dat.Field<string>("CodigoAdelantoInsentivo").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colCodigoAdelantoInsentivo = new GridViewTextBoxColumn();
            colCodigoAdelantoInsentivo.FieldName = "CodigoAdelantoInsentivo";
            colCodigoAdelantoInsentivo.HeaderText = "Codigo";
            colCodigoAdelantoInsentivo.MinWidth = Consulta.AnchoTexto(WidthText > colCodigoAdelantoInsentivo.HeaderText.Length
                                            ? col.First().Field<string>("CodigoAdelantoInsentivo").ToString()
                                            : colCodigoAdelantoInsentivo.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colCodigoAdelantoInsentivo.Name = "colCodigoAdelantoInsentivo";
            colCodigoAdelantoInsentivo.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colCodigoAdelantoInsentivo);

            data = dttAdelantoInsentivo.AsEnumerable().Select(Proveedor => Proveedor.Field<string>("Proveedor").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttAdelantoInsentivo.AsEnumerable()
                  where dat.Field<string>("Proveedor").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colProveedor = new GridViewTextBoxColumn();
            colProveedor.FieldName = "Proveedor";
            colProveedor.HeaderText = "Proveedor";
            colProveedor.MinWidth = Consulta.AnchoTexto(WidthText > colProveedor.HeaderText.Length
                                            ? col.First().Field<string>("Proveedor").ToString()
                                            : colProveedor.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colProveedor.Name = "colProveedor";
            colProveedor.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colProveedor);

            data = dttAdelantoInsentivo.AsEnumerable().Select(Nombre => Nombre.Field<int>("UnidadxAdelantoInsentivo").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttAdelantoInsentivo.AsEnumerable()
                  where dat.Field<string>("UnidadxAdelantoInsentivo").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colUnidadxAdelantoInsentivo = new GridViewTextBoxColumn();
            colUnidadxAdelantoInsentivo.DataType = typeof(decimal);
            colUnidadxAdelantoInsentivo.FieldName = "UnidadxAdelantoInsentivo";
            colUnidadxAdelantoInsentivo.FormatString = "{0:G}";
            colUnidadxAdelantoInsentivo.HeaderText = "Unidad por AdelantoInsentivo";
            colUnidadxAdelantoInsentivo.MinWidth = Consulta.AnchoTexto(WidthText > colUnidadxAdelantoInsentivo.HeaderText.Length
                                            ? col.First().Field<int>("UnidadxAdelantoInsentivo").ToString()
                                            : colUnidadxAdelantoInsentivo.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colUnidadxAdelantoInsentivo.Name = "colUnidadxAdelantoInsentivo";
            colUnidadxAdelantoInsentivo.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colUnidadxAdelantoInsentivo);

            data = dttAdelantoInsentivo.AsEnumerable().Select(Nombre => Nombre.Field<int>("ValorCompra").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttAdelantoInsentivo.AsEnumerable()
                  where dat.Field<string>("ValorCompra").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colValorCompra = new GridViewTextBoxColumn();
            colValorCompra.DataType = typeof(decimal);
            colValorCompra.FieldName = "ValorCompra";
            colValorCompra.FormatString = "{0:C}";
            colValorCompra.HeaderText = "Valor de Compra";
            colValorCompra.MinWidth = Consulta.AnchoTexto(WidthText > colValorCompra.HeaderText.Length
                                            ? col.First().Field<int>("ValorCompra").ToString()
                                            : colValorCompra.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colValorCompra.Name = "colValorCompra";
            colValorCompra.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colValorCompra);

            data = dttAdelantoInsentivo.AsEnumerable().Select(Nombre => Nombre.Field<int>("ValorVentaXUnidad").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttAdelantoInsentivo.AsEnumerable()
                  where dat.Field<string>("ValorVentaXUnidad").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colValorVentaXUnidad = new GridViewTextBoxColumn();
            colValorVentaXUnidad.DataType = typeof(decimal);
            colValorVentaXUnidad.FieldName = "ValorVentaXUnidad";
            colValorVentaXUnidad.FormatString = "{0:C}";
            colValorVentaXUnidad.HeaderText = "Valor de Venta Unidad";
            colValorVentaXUnidad.MinWidth = Consulta.AnchoTexto(WidthText > colValorVentaXUnidad.HeaderText.Length
                                            ? col.First().Field<int>("ValorVentaXUnidad").ToString()
                                            : colValorVentaXUnidad.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colValorVentaXUnidad.Name = "colValorVentaXUnidad";
            colValorVentaXUnidad.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colValorVentaXUnidad);

            data = dttAdelantoInsentivo.AsEnumerable().Select(Nombre => Nombre.Field<int>("PorcentajeVentaPublico").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttAdelantoInsentivo.AsEnumerable()
                  where dat.Field<string>("PorcentajeVentaPublico").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colPorcentajeVentaPublico = new GridViewTextBoxColumn();
            colPorcentajeVentaPublico.DataType = typeof(decimal);
            colPorcentajeVentaPublico.FieldName = "PorcentajeVentaPublico";
            colPorcentajeVentaPublico.FormatString = "{0:G}";
            colPorcentajeVentaPublico.HeaderText = "Porcentaje de Bonificación";
            colPorcentajeVentaPublico.MinWidth = Consulta.AnchoTexto(WidthText > colPorcentajeVentaPublico.HeaderText.Length
                                            ? col.First().Field<int>("PorcentajeVentaPublico").ToString()
                                            : colPorcentajeVentaPublico.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colPorcentajeVentaPublico.Name = "colPorcentajeVentaPublico";
            colPorcentajeVentaPublico.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colPorcentajeVentaPublico);

            data = dttAdelantoInsentivo.AsEnumerable().Select(Nombre => Nombre.Field<int>("DescuentoVentaInterna").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttAdelantoInsentivo.AsEnumerable()
                  where dat.Field<string>("DescuentoVentaInterna").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colDescuentoVentaInterna = new GridViewTextBoxColumn();
            colDescuentoVentaInterna.DataType = typeof(decimal);
            colDescuentoVentaInterna.FieldName = "DescuentoVentaInterna";
            colDescuentoVentaInterna.FormatString = "{0:G}";
            colDescuentoVentaInterna.HeaderText = "Unidad por AdelantoInsentivo";
            colDescuentoVentaInterna.MinWidth = Consulta.AnchoTexto(WidthText > colDescuentoVentaInterna.HeaderText.Length
                                            ? col.First().Field<int>("DescuentoVentaInterna").ToString()
                                            : colDescuentoVentaInterna.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colDescuentoVentaInterna.Name = "colDescuentoVentaInterna";
            colDescuentoVentaInterna.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colDescuentoVentaInterna);

            GridViewCheckBoxColumn colInsumo = new GridViewCheckBoxColumn();
            colInsumo.FieldName = "Insumo";
            colInsumo.HeaderText = "Insumo";
            colInsumo.MinWidth = Consulta.AnchoTexto("Insumo", RadGridViewAdelantoInsentivos.Font);
            colInsumo.Name = "colInsumo";
            colInsumo.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colInsumo);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewAdelantoInsentivos.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colActivo);

            RadGridViewAdelantoInsentivos.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewAdelantoInsentivos_CurrentRowChanged);

            RadGridViewAdelantoInsentivos.DataSource = dttAdelantoInsentivo;
        }

        private void RadGridViewAdelantoInsentivos_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow == null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.AdelantoInsentivoID = int.Parse(dtsAdelantoInsentivo.Rows[RowIndex]["AdelantoInsentivoID"].ToString());
            RadChkAdelanto.Checked = bool.Parse(dttAdelantoInsentivo.Rows[RowIndex]["Adelanto"].ToString());
            RadMskValorCompra.Text = dttAdelantoInsentivo.Rows[RowIndex]["ValorAdelantoInsentivo"].ToString();
            RadChkActivo.Checked = bool.Parse(dttAdelantoInsentivo.Rows[RowIndex]["Activo"].ToString());
            RadDrpUsuario.SelectedValue = int.Parse(dttAdelantoInsentivo.Rows[RowIndex]["UsuarioAdelantoInsentivoID"].ToString());
        }

        private void Habilita(bool estado)
        {
            RadMskValorCompra.Enabled = estado;
            RadChkActivo.Enabled = estado;
            RadChkAdelanto.Enabled = estado;
            RadDrpUsuario.Enabled = estado;
        }

        private void RadMenuItemAdicionar_Click(object sender, EventArgs e)
        {
            Limpia();
            Habilita(true);
            RadChkActivo.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewAdelantoInsentivos.Enabled = false;
            RadDrpUsuario.Focus();
        }

        private void Limpia()
        {
            RadMskValorCompra.Value = "";
            RadChkActivo.Checked = true;
            RadChkAdelanto.Checked = false;
            RadDrpUsuario.SelectedIndex = -1;
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewAdelantoInsentivos.Enabled = false;
            RadDrpUsuario.Focus();
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            bool modifica = RadMenuItemEditar.Enabled;

            if (ValidaCambios(modifica))
            {
                RadMessageBox.Show("No se han realizado cambios.", "ALERTA");
                return;
            }

            AdelantoInsentivo Product = new AdelantoInsentivo();
            Product.AdelantoInsentivoID = modifica ? int.Parse(dttAdelantoInsentivo.Rows[RowIndex]["AdelantoInsentivoID"].ToString()) : 0;
            Product.ValorAdelantoInsentivo= Convert.ToInt32(float.Parse(RadMskValorCompra.Value.ToString()));
            Product.Adelanto = RadChkAdelanto.Checked;
            Product.Activo = RadChkActivo.Checked;
            Product.UsuarioAdelantoInsentivoID = RadDrpUsuario.SelectedIndex > -1 ? int.Parse(RadDrpUsuario.SelectedValue.ToString()) : 0;

            DataSet dtsSave = Consulta.GuardaAdelantoInsentivo(modifica, Product);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            TablaAdelantoInsentivo();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewAdelantoInsentivos.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaAdelantoInsentivo();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewAdelantoInsentivos.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;

            if (modifica)
            {

                cont = float.Parse(RadMskValorCompra.Value.ToString()) != float.Parse(dttAdelantoInsentivo.Rows[RowIndex]["ValorAdelantoInsentivo"].ToString()) ? (cont + 1) : cont;

                cont = RadChkAdelanto.Checked != bool.Parse(dttAdelantoInsentivo.Rows[RowIndex]["Adelanto"].ToString()) ? (cont + 1) : cont;

                cont = RadChkActivo.Checked != bool.Parse(dttAdelantoInsentivo.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont;

                cont = RadDrpUsuario.SelectedIndex > -1 ? int.Parse(RadDrpUsuario.SelectedValue.ToString()) : 0
                    != int.Parse(dttAdelantoInsentivo.Rows[RowIndex]["UsuarioAdelantoInsentivoID"].ToString()) ? (cont + 1) : cont;
            }

            return modifica ? cont == 0 : modifica;
        }

        
    }
}