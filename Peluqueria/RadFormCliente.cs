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
    public partial class RadFormCliente : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttCliente = new DataTable();
        Negocio Consulta = new Negocio();
        int RowIndex = -1;

        public RadFormCliente()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaCliente();
            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaCliente()
        {
            dts = Consulta.ConsultaCliente();

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {
                var product = from prod in dts.Tables[1].Copy().AsEnumerable()
                              where prod.Field<bool>("Activo") == (Program.User.RolID == 1 ? prod.Field<bool>("Activo") : true)
                              select prod;

                if (product.Count() > 0)
                {
                    dttCliente = product.CopyToDataTable();
                    ConfiguraGrilla();

                }
                else
                {
                    RadGridViewCliente.DataSource = new DataTable();
                    RadGridViewCliente.Columns.Clear();
                }


                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewCliente.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewClientes_CurrentRowChanged);

            RadGridViewCliente.DataSource = new DataTable();
            RadGridViewCliente.Columns.Clear();

            RadGridViewCliente.EnableFiltering = true;
            RadGridViewCliente.AutoGenerateColumns = false;
            RadGridViewCliente.AllowAddNewRow = false;
            RadGridViewCliente.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewCliente.MasterTemplate.ShowFilteringRow = false;
            RadGridViewCliente.TableElement.EndUpdate();
            RadGridViewCliente.AllowDeleteRow = false;
            RadGridViewCliente.AllowRowResize = false;
            RadGridViewCliente.AllowEditRow = true;
            RadGridViewCliente.ShowRowHeaderColumn = false;
            RadGridViewCliente.Select();
            RadGridViewCliente.EnableSorting = true;

            List<int> data = dttCliente.AsEnumerable().Select(Nombre => Nombre.Field<string>("Nombre").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttCliente.AsEnumerable()
                      where dat.Field<string>("Nombre").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colNombre = new GridViewTextBoxColumn();
            colNombre.FieldName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinWidth = Consulta.AnchoTexto(WidthText > colNombre.HeaderText.Length
                                            ? col.First().Field<string>("Nombre").ToString()
                                            : colNombre.HeaderText, RadGridViewCliente.Font);
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            RadGridViewCliente.Columns.Add(colNombre);

            data = dttCliente.AsEnumerable().Select(Correo => Correo.Field<string>("Correo").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttCliente.AsEnumerable()
                      where dat.Field<string>("Correo").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colCorreo = new GridViewTextBoxColumn();
            colCorreo.FieldName = "Correo";
            colCorreo.HeaderText = "Correo";
            colCorreo.MinWidth = Consulta.AnchoTexto(WidthText > colCorreo.HeaderText.Length
                                            ? col.First().Field<string>("Correo").ToString()
                                            : colCorreo.HeaderText, RadGridViewCliente.Font);
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            RadGridViewCliente.Columns.Add(colCorreo);

            data = dttCliente.AsEnumerable().Select(Telefono => Telefono.Field<string>("Telefono").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttCliente.AsEnumerable()
                  where dat.Field<string>("Telefono").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colTelefono = new GridViewTextBoxColumn();
            colTelefono.FieldName = "Telefono";
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinWidth = Consulta.AnchoTexto(WidthText > colTelefono.HeaderText.Length
                                            ? col.First().Field<string>("Telefono").ToString()
                                            : colTelefono.HeaderText, RadGridViewCliente.Font);
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            RadGridViewCliente.Columns.Add(colTelefono);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewCliente.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewCliente.Columns.Add(colActivo);

            RadGridViewCliente.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewClientes_CurrentRowChanged);

            RadGridViewCliente.DataSource = dttCliente;
        }

        private void RadGridViewClientes_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow == null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.ClienteID = int.Parse(dtsCliente.Rows[RowIndex]["ClienteID"].ToString());
            RadTxtNombre.Text = dttCliente.Rows[RowIndex]["Nombre"].ToString();
            RadMskCorreo.Text = dttCliente.Rows[RowIndex]["Correo"].ToString();
            RadMskTelefono.Text = dttCliente.Rows[RowIndex]["Telefono"].ToString();
            RadChkActivo.Checked = bool.Parse(dttCliente.Rows[RowIndex]["Activo"].ToString());
        }

        private void Habilita(bool estado)
        {
            RadTxtNombre.Enabled = estado;
            RadMskCorreo.Enabled = estado;
            RadMskTelefono.Enabled = estado;
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
            RadGridViewCliente.Enabled = false;
            RadTxtNombre.Focus();
        }

        private void Limpia()
        {
            RadTxtNombre.Text = "";
            RadMskCorreo.Value = "";
            RadMskTelefono.Value = "";
            RadChkActivo.Checked = true;
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewCliente.Enabled = false;
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

            Cliente Product = new Cliente();
            Product.ClienteID = modifica ? int.Parse(dttCliente.Rows[RowIndex]["ClienteID"].ToString()) : 0;
            Product.Nombre = RadTxtNombre.Text;
            Product.Correo = RadMskCorreo.Value.ToString();
            Product.Telefono = RadMskTelefono.Value.ToString();
            Product.Activo = RadChkActivo.Checked;

            DataSet dtsSave = Consulta.GuardaCliente(modifica, Product);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            dts = Consulta.ConsultaCliente();
            TablaCliente();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewCliente.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaCliente();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewCliente.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;

            if (modifica)
            {
                cont = RadTxtNombre.Text != dttCliente.Rows[RowIndex]["Nombre"].ToString() ? (cont + 1) : cont;
                cont = RadMskCorreo.Value.ToString() != dttCliente.Rows[RowIndex]["Correo"].ToString() ? (cont + 1) : cont;
                cont = RadMskTelefono.Value.ToString() != dttCliente.Rows[RowIndex]["Telefono"].ToString() ? (cont + 1) : cont;
                cont = RadChkActivo.Checked != bool.Parse(dttCliente.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont;

            }

            return modifica ? cont == 0 : modifica;
        }
        
    }
}