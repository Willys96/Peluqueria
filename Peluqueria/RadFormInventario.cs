using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Peluqueria.Clases;

namespace Peluqueria
{
    public partial class RadFormInventario : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttInventario = new DataTable();
        Negocio Consulta = new Negocio();
        int RowIndex=-1;

        public RadFormInventario()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaInventario();
            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaInventario()
        {
            dts = Consulta.ConsultaInventario();

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {
                var invent = from inv in dts.Tables[1].Copy().AsEnumerable()
                              where inv.Field<bool>("Activo") == (Program.User.RolID == 1 ? inv.Field<bool>("Activo") : true)
                              select inv;

                if (invent.Count() > 0)
                {
                    dttInventario = invent.CopyToDataTable();

                    RadDrpProducto.DataSource = dttInventario;
                    RadDrpProducto.DisplayMember = "Producto";
                    RadDrpProducto.ValueMember = "ProductoID";
                    RadDrpProducto.SelectedIndex = -1;
                    RadDrpProducto.Enabled = false;

                    ConfiguraGrilla();

                }
                else
                {
                    RadGridViewInventarios.DataSource = new DataTable();
                    RadGridViewInventarios.Columns.Clear();
                }

                Limpia();
                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewInventarios.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewInventarios_CurrentRowChanged);

            RadGridViewInventarios.DataSource = new DataTable();
            RadGridViewInventarios.Columns.Clear();

            RadGridViewInventarios.EnableFiltering = true;
            RadGridViewInventarios.AutoGenerateColumns = false;
            RadGridViewInventarios.AllowAddNewRow = false;
            RadGridViewInventarios.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewInventarios.MasterTemplate.ShowFilteringRow = false;
            RadGridViewInventarios.TableElement.EndUpdate();
            RadGridViewInventarios.AllowDeleteRow = false;
            RadGridViewInventarios.AllowRowResize = false;
            RadGridViewInventarios.AllowEditRow = true;
            RadGridViewInventarios.ShowRowHeaderColumn = false;
            RadGridViewInventarios.Select();
            RadGridViewInventarios.EnableSorting = true;

            List<int> data = dttInventario.AsEnumerable().Select(Producto => Producto.Field<string>("Producto").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttInventario.AsEnumerable()
                      where dat.Field<string>("Producto").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colProducto = new GridViewTextBoxColumn();
            colProducto.FieldName = "Producto";
            colProducto.HeaderText = "Producto";
            colProducto.MinWidth = Consulta.AnchoTexto(WidthText > colProducto.HeaderText.Length
                                            ? col.First().Field<string>("Producto").ToString()
                                            : colProducto.HeaderText, RadGridViewInventarios.Font);
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            RadGridViewInventarios.Columns.Add(colProducto);

            data = dttInventario.AsEnumerable().Select(Nombre => Nombre.Field<int>("CantidadUnidad").ToString().Length).ToList();
            WidthText = data.Max();
            col = from dat in dttInventario.AsEnumerable()
                  where dat.Field<string>("CantidadUnidad").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colCantidadUnidad = new GridViewTextBoxColumn();
            colCantidadUnidad.DataType = typeof(decimal);
            colCantidadUnidad.FieldName = "CantidadUnidad";
            colCantidadUnidad.FormatString = "{0:G}";
            colCantidadUnidad.HeaderText = "Unidad por Inventario";
            colCantidadUnidad.MinWidth = Consulta.AnchoTexto(WidthText > colCantidadUnidad.HeaderText.Length
                                            ? col.First().Field<int>("CantidadUnidad").ToString()
                                            : colCantidadUnidad.HeaderText, RadGridViewInventarios.Font);
            colCantidadUnidad.Name = "colCantidadUnidad";
            colCantidadUnidad.ReadOnly = true;
            RadGridViewInventarios.Columns.Add(colCantidadUnidad);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewInventarios.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewInventarios.Columns.Add(colActivo);

            RadGridViewInventarios.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewInventarios_CurrentRowChanged);

            RadGridViewInventarios.DataSource = dttInventario;
        }

        private void RadGridViewInventarios_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow==null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            RadDrpProducto.SelectedValue = int.Parse(dttInventario.Rows[RowIndex]["ProductoID"].ToString());
        }

        private void Habilita(bool estado)
        {
            RadMskCantidadUnidad.Enabled = estado;
        }

        private void RadMenuItemAdicionar_Click(object sender, EventArgs e)
        {
            Limpia();
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewInventarios.Enabled = false;
            RadDrpProducto.Focus();
        }

        private void Limpia()
        {
            RadMskCantidadUnidad.Value = "";
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewInventarios.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadDrpProducto.Focus();
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            bool modifica = RadMenuItemEditar.Enabled;

            if (RadMessageBox.Show("Seguro desea guardar la información suministrada?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (Convert.ToInt32(float.Parse(RadMskCantidadUnidad.Value.ToString()))==0)
            {
                RadMessageBox.Show("El valor de Cantidad debe ser mayor a 0.", "ALERTA");
                return;
            }

            DataSet dtsSave = Consulta.ModificaInventario(int.Parse(RadDrpProducto.SelectedValue.ToString()), Convert.ToInt32(float.Parse(RadMskCantidadUnidad.Value.ToString())), RadMenuItemAdicionar.Enabled);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            dts = Consulta.ConsultaInventario();
            TablaInventario();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewInventarios.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            Habilita(false);
            TablaInventario();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewInventarios.Enabled = true;
        }

    }
}
