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
    public partial class RadFormServicios : Telerik.WinControls.UI.RadForm
    {

        DataSet dts = new DataSet();
        DataTable dttServicio = new DataTable();
        Negocio Consulta = new Negocio();

        int RowIndex = -1;
        public RadFormServicios()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaServicio();
            RadMenuItemGuardar.Enabled = false;

            
        }

        protected void TablaServicio()
        {
            dts = Consulta.ConsultaServicio();

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {
                var service = from prod in dts.Tables[1].Copy().AsEnumerable()
                              where prod.Field<bool>("Activo") == (Program.User.RolID == 1 ? prod.Field<bool>("Activo") : true)
                              select prod;

                if (service.Count() > 0)
                {
                    dttServicio = service.CopyToDataTable();

                    ConfiguraGrilla();
                }
                else
                {
                    RadGridViewServicios.DataSource = new DataTable();
                    RadGridViewServicios.Columns.Clear();
                }

                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewServicios.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewServicios_CurrentRowChanged);

            RadGridViewServicios.DataSource = new DataTable();
            RadGridViewServicios.Columns.Clear();

            RadGridViewServicios.EnableFiltering = true;
            RadGridViewServicios.AutoGenerateColumns = false;
            RadGridViewServicios.AllowAddNewRow = false;
            RadGridViewServicios.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewServicios.MasterTemplate.ShowFilteringRow = false;
            RadGridViewServicios.TableElement.EndUpdate();
            RadGridViewServicios.AllowDeleteRow = false;
            RadGridViewServicios.AllowRowResize = false;
            RadGridViewServicios.AllowEditRow = true;
            RadGridViewServicios.ShowRowHeaderColumn = false;
            RadGridViewServicios.Select();
            RadGridViewServicios.EnableSorting = true;

            List<int> data = dttServicio.AsEnumerable().Select(Nombre => Nombre.Field<string>("Nombre").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttServicio.AsEnumerable()
                      where dat.Field<string>("Nombre").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colNombre = new GridViewTextBoxColumn();
            colNombre.FieldName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinWidth = Consulta.AnchoTexto(WidthText > colNombre.HeaderText.Length
                                            ? col.First().Field<string>("Nombre").ToString()
                                            : colNombre.HeaderText, RadGridViewServicios.Font);
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            RadGridViewServicios.Columns.Add(colNombre);

            data = dttServicio.AsEnumerable().Select(Nombre => Nombre.Field<string>("CodigoServicio").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttServicio.AsEnumerable()
                  where dat.Field<string>("CodigoServicio").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colCodigoServicio = new GridViewTextBoxColumn();
            colCodigoServicio.DataType = typeof(decimal);
            colCodigoServicio.FieldName = "CodigoServicio";
            colCodigoServicio.FormatString = "{0:C}";
            colCodigoServicio.HeaderText = "Codigo";
            colCodigoServicio.MinWidth = Consulta.AnchoTexto(WidthText > colCodigoServicio.HeaderText.Length
                                            ? col.First().Field<int>("CodigoServicio").ToString()
                                            : colCodigoServicio.HeaderText, RadGridViewServicios.Font);
            colCodigoServicio.Name = "colCodigoServicio";
            colCodigoServicio.ReadOnly = true;
            RadGridViewServicios.Columns.Add(colCodigoServicio);

            data = dttServicio.AsEnumerable().Select(Nombre => Nombre.Field<int>("ValorVenta").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttServicio.AsEnumerable()
                  where dat.Field<string>("ValorVenta").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colValorVenta = new GridViewTextBoxColumn();
            colValorVenta.DataType = typeof(decimal);
            colValorVenta.FieldName = "ValorVenta";
            colValorVenta.FormatString = "{0:C}";
            colValorVenta.HeaderText = "Valor de Compra";
            colValorVenta.MinWidth = Consulta.AnchoTexto(WidthText > colValorVenta.HeaderText.Length
                                            ? col.First().Field<int>("ValorVenta").ToString()
                                            : colValorVenta.HeaderText, RadGridViewServicios.Font);
            colValorVenta.Name = "colValorVenta";
            colValorVenta.ReadOnly = true;
            RadGridViewServicios.Columns.Add(colValorVenta);

            data = dttServicio.AsEnumerable().Select(Nombre => Nombre.Field<short>("PorcentajeEstilista").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttServicio.AsEnumerable()
                  where dat.Field<string>("PorcentajeEstilista").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colPorcentajeEstilista = new GridViewTextBoxColumn();
            colPorcentajeEstilista.DataType = typeof(decimal);
            colPorcentajeEstilista.FieldName = "PorcentajeEstilista";
            colPorcentajeEstilista.FormatString = "{0:G}";
            colPorcentajeEstilista.HeaderText = "Valor de Venta Unidad";
            colPorcentajeEstilista.MinWidth = Consulta.AnchoTexto(WidthText > colPorcentajeEstilista.HeaderText.Length
                                            ? col.First().Field<int>("PorcentajeEstilista").ToString()
                                            : colPorcentajeEstilista.HeaderText, RadGridViewServicios.Font);
            colPorcentajeEstilista.Name = "colPorcentajeEstilista";
            colPorcentajeEstilista.ReadOnly = true;
            RadGridViewServicios.Columns.Add(colPorcentajeEstilista);


            GridViewCheckBoxColumn colVariable = new GridViewCheckBoxColumn();
            colVariable.FieldName = "Variable";
            colVariable.HeaderText = "Variable";
            colVariable.MinWidth = Consulta.AnchoTexto("Variable", RadGridViewServicios.Font);
            colVariable.Name = "colVariable";
            colVariable.ReadOnly = true;
            RadGridViewServicios.Columns.Add(colVariable);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewServicios.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewServicios.Columns.Add(colActivo);

            RadGridViewServicios.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewServicios_CurrentRowChanged);

            RadGridViewServicios.DataSource = dttServicio;
        }

        private void RadGridViewServicios_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow == null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.ServicioID = int.Parse(dtsServicio.Rows[RowIndex]["ServicioID"].ToString());
            RadTxtNombre.Text = dttServicio.Rows[RowIndex]["Nombre"].ToString();
            RadMskValorVenta.Text = dttServicio.Rows[RowIndex]["ValorVenta"].ToString();
            RadMskPorcentajeEstilista.Text = dttServicio.Rows[RowIndex]["PorcentajeEstilista"].ToString();
            RadTxtCodigo.Text = dttServicio.Rows[RowIndex]["CodigoServicio"].ToString();
            RadChkVariable.Checked = bool.Parse(dttServicio.Rows[RowIndex]["Variable"].ToString());
            RadChkActivo.Checked = bool.Parse(dttServicio.Rows[RowIndex]["Activo"].ToString());

        }

        private void Habilita(bool estado)
        {
            RadTxtNombre.Enabled = estado;
            RadMskValorVenta.Enabled = estado;
            RadMskPorcentajeEstilista.Enabled = estado;
            RadTxtCodigo.Enabled = estado;
            RadChkVariable.Enabled = estado;
            RadChkActivo.Enabled = estado;
        }

        private void RadMenuItemAdicionar_Click(object sender, EventArgs e)
        {
            RowIndex = -1;
            Limpia();
            Habilita(true);
            RadChkActivo.Enabled = false;
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewServicios.Enabled = false;

            RadTxtNombre.Focus();
        }

        private void Limpia()
        {
            RadTxtNombre.Text = "";
            RadMskValorVenta.Value = "";
            RadMskPorcentajeEstilista.Value = "";
            RadTxtCodigo.Text = "";
            RadChkVariable.Checked = false;
            RadChkActivo.Checked = true;
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMskValorVenta.Enabled = !RadChkVariable.Checked;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewServicios.Enabled = false;
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


            Servicio service = new Servicio();
            service.ServicioID = modifica ? int.Parse(dttServicio.Rows[RowIndex]["ServicioID"].ToString()) : 0;
            service.Nombre = RadTxtNombre.Text;
            service.ValorVenta = Convert.ToInt32(float.Parse(RadMskValorVenta.Value.ToString()));
            service.PorcentajeEstilista = Convert.ToInt32(float.Parse(RadMskPorcentajeEstilista.Value.ToString())*100);
            service.CodigoServicio = RadTxtCodigo.Text.ToString();
            service.Variable = RadChkVariable.Checked;
            service.Activo = RadChkActivo.Checked;


            DataSet dtsSave = Consulta.GuardaServicio(modifica, service);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            dts = Consulta.ConsultaServicio();
            TablaServicio();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewServicios.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaServicio();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewServicios.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;
            bool deactivo = false;

            if (modifica)
            {
                cont = RadTxtNombre.Text != dttServicio.Rows[RowIndex]["Nombre"].ToString() ? (cont + 1) : cont;
                cont = float.Parse(RadMskValorVenta.Value.ToString()) != float.Parse(dttServicio.Rows[RowIndex]["ValorVenta"].ToString()) ? (cont + 1) : cont;
                cont = Convert.ToInt16( float.Parse(RadMskPorcentajeEstilista.Value.ToString())*100) != int.Parse(dttServicio.Rows[RowIndex]["PorcentajeEstilista"].ToString()) ? (cont + 1) : cont;

                cont = RadTxtCodigo.Text.ToString() != dttServicio.Rows[RowIndex]["CodigoServicio"].ToString() ? (cont + 1) : cont;
                cont = RadChkVariable.Checked != bool.Parse(dttServicio.Rows[RowIndex]["Variable"].ToString()) ? (cont + 1) : cont;
                cont = RadChkActivo.Checked != bool.Parse(dttServicio.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont;

                deactivo = RadChkActivo.Checked != bool.Parse(dttServicio.Rows[RowIndex]["Activo"].ToString());
            }

            return modifica ? cont == 0 : modifica;
        }

        private void RadChkVariable_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if(RadChkVariable.Checked)
            {
                RadMskValorVenta.Value = 0;
                RadMskValorVenta.Enabled = false;

            }
            else
            {
                if(RowIndex>0)
                {
                    RadMskValorVenta.Value = int.Parse(dts.Tables[1].Rows[RowIndex]["ValorVenta"].ToString());
                }
                RadMskValorVenta.Enabled = true && RadMenuItemGuardar.Enabled;
            }
        }
    }
}
