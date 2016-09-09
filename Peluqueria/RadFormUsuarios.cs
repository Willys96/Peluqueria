using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Peluqueria.Clases;
using System.Linq;
using Telerik.WinControls.UI;

namespace Peluqueria
{
    public partial class RadFormUsuarios : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttUsuario = new DataTable();
        Negocio Consulta = new Negocio();
        int RowIndex = -1;
        
        public RadFormUsuarios()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            //dts = Consulta.ConsultaUsuario();

            //if (dts.Tables[0].Rows[0]["Resultado"].ToString()=="1")
            //{

            //    var roles = from rol in dts.Tables[2].Copy().AsEnumerable()
            //                where rol.Field<int>("RolID") > 1
            //                select rol;

            //    if (roles.Count() > 0)
            //    {
            //        RadDrpRol.DataSource = roles.CopyToDataTable();
            //        RadDrpRol.ValueMember = "RolID";
            //        RadDrpRol.DisplayMember = "Nombre";
            //        RadDrpRol.SelectedIndex = -1;
            //        RadDrpRol.Text = "";
            //    }

            TablaUsuario();
            //}

            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaUsuario()
        {
            dts = Consulta.ConsultaUsuario();

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {
                var roles = from rol in dts.Tables[2].Copy().AsEnumerable()
                            where rol.Field<int>("RolID") > 1
                            select rol;

                if (roles.Count() > 0)
                {
                    RadDrpRol.DataSource = roles.CopyToDataTable();
                    RadDrpRol.ValueMember = "RolID";
                    RadDrpRol.DisplayMember = "Nombre";
                    RadDrpRol.SelectedIndex = -1;
                    RadDrpRol.Text = "";
                }

                var users = from user in dts.Tables[1].Copy().AsEnumerable()
                            where user.Field<int>("RolID") > (Program.User.RolID == 1 ? -1 : 1) //&& user.Field<int>("UsuarioID") != Program.User.UsuarioID
                            select user;

                if (users.Count() > 0)
                {
                    dttUsuario = users.CopyToDataTable();

                    ConfiguraGrilla();

                    cargaGrilla();
                }
                else
                {
                    RadGridViewUsuarios.DataSource = new DataTable();
                    RadGridViewUsuarios.Columns.Clear();
                }

                Habilita(false); 
            }
        }

        protected void ConfiguraGrilla()
        {
            RadGridViewUsuarios.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewUsuarios_CurrentRowChanged);

            RadGridViewUsuarios.DataSource = new DataTable();
            RadGridViewUsuarios.Columns.Clear();

            RadGridViewUsuarios.EnableFiltering = true;
            RadGridViewUsuarios.AutoGenerateColumns = false;
            RadGridViewUsuarios.AllowAddNewRow = false;
            RadGridViewUsuarios.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewUsuarios.MasterTemplate.ShowFilteringRow = false;
            RadGridViewUsuarios.TableElement.EndUpdate();
            RadGridViewUsuarios.AllowDeleteRow = false;
            RadGridViewUsuarios.AllowRowResize = false;
            RadGridViewUsuarios.AllowEditRow = true;
            RadGridViewUsuarios.ShowRowHeaderColumn = false;
            RadGridViewUsuarios.Select();
            RadGridViewUsuarios.EnableSorting = true;

            List<int> data = dttUsuario.AsEnumerable().Select(Nombre => Nombre.Field<string>("Nombre").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttUsuario.AsEnumerable()
                      where dat.Field<string>("Nombre").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colNombre = new GridViewTextBoxColumn();
            colNombre.FieldName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinWidth = Consulta.AnchoTexto(WidthText > colNombre.HeaderText.Length
                                            ? col.First().Field<string>("Nombre").ToString()
                                            : colNombre.HeaderText, RadGridViewUsuarios.Font);
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            RadGridViewUsuarios.Columns.Add(colNombre);

            data = dttUsuario.AsEnumerable().Select(Nombre => Nombre.Field<string>("Apellido").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttUsuario.AsEnumerable()
                      where dat.Field<string>("Apellido").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colApellido = new GridViewTextBoxColumn();
            colApellido.FieldName = "Apellido";
            colApellido.HeaderText = "Apellido";
            colApellido.MinWidth = Consulta.AnchoTexto(WidthText > colApellido.HeaderText.Length
                                            ? col.First().Field<string>("Apellido").ToString()
                                            : colApellido.HeaderText, RadGridViewUsuarios.Font);
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            RadGridViewUsuarios.Columns.Add(colApellido);

            data = dttUsuario.AsEnumerable().Select(Nombre => Nombre.Field<string>("CodigoUsuario").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttUsuario.AsEnumerable()
                  where dat.Field<string>("CodigoUsuario").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colCodigoUsuario = new GridViewTextBoxColumn();
            colCodigoUsuario.FieldName = "CodigoUsuario";
            colCodigoUsuario.HeaderText = "Codigo de Usuario";
            colCodigoUsuario.MinWidth = Consulta.AnchoTexto(WidthText > colCodigoUsuario.HeaderText.Length
                                            ? col.First().Field<string>("CodigoUsuario").ToString()
                                            : colCodigoUsuario.HeaderText, RadGridViewUsuarios.Font);
            colCodigoUsuario.Name = "colCodigoUsuario";
            colCodigoUsuario.ReadOnly = true;
            RadGridViewUsuarios.Columns.Add(colCodigoUsuario);

            data = dttUsuario.AsEnumerable().Select(Nombre => Nombre.Field<string>("NombreUsuario").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttUsuario.AsEnumerable()
                  where dat.Field<string>("NombreUsuario").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colNombreUsuario = new GridViewTextBoxColumn();
            colNombreUsuario.FieldName = "NombreUsuario";
            colNombreUsuario.HeaderText = "NombreUsuario";
            colNombreUsuario.MinWidth = Consulta.AnchoTexto(WidthText > colNombreUsuario.HeaderText.Length
                                            ? col.First().Field<string>("NombreUsuario").ToString()
                                            : colNombreUsuario.HeaderText, RadGridViewUsuarios.Font);
            colNombreUsuario.Name = "colNombreUsuario";
            colNombreUsuario.ReadOnly = true;
            RadGridViewUsuarios.Columns.Add(colNombreUsuario);

            data = dttUsuario.AsEnumerable().Select(Nombre => Nombre.Field<string>("Documento").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttUsuario.AsEnumerable()
                  where dat.Field<string>("Documento").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colDocumento = new GridViewTextBoxColumn();
            colDocumento.FieldName = "Documento";
            colDocumento.HeaderText = "Documento";
            colDocumento.MinWidth = Consulta.AnchoTexto(WidthText > colDocumento.HeaderText.Length
                                            ? col.First().Field<string>("Documento").ToString()
                                            : colDocumento.HeaderText, RadGridViewUsuarios.Font);
            colDocumento.Name = "colDocumento";
            colDocumento.ReadOnly = true;
            RadGridViewUsuarios.Columns.Add(colDocumento);

            data = dttUsuario.AsEnumerable().Select(Nombre => Nombre.Field<string>("Telefono").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttUsuario.AsEnumerable()
                  where dat.Field<string>("Telefono").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colTelefono = new GridViewTextBoxColumn();
            colTelefono.FieldName = "Telefono";
            colTelefono.HeaderText = "Telefono";
            colTelefono.MinWidth = Consulta.AnchoTexto(WidthText > colTelefono.HeaderText.Length
                                            ? col.First().Field<string>("Telefono").ToString()
                                            : colTelefono.HeaderText, RadGridViewUsuarios.Font);
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            RadGridViewUsuarios.Columns.Add(colTelefono);

            data = dttUsuario.AsEnumerable().Select(Nombre => Nombre.Field<string>("Direccion").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttUsuario.AsEnumerable()
                  where dat.Field<string>("Direccion").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colDireccion = new GridViewTextBoxColumn();
            colDireccion.FieldName = "Direccion";
            colDireccion.HeaderText = "Direccion";
            colDireccion.MinWidth = Consulta.AnchoTexto(WidthText > colDireccion.HeaderText.Length
                                            ? col.First().Field<string>("Direccion").ToString()
                                            : colDireccion.HeaderText, RadGridViewUsuarios.Font);
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            RadGridViewUsuarios.Columns.Add(colDireccion);

            data = dttUsuario.AsEnumerable().Select(Nombre => Nombre.Field<string>("Rol").Length).ToList();
            WidthText = data.Max();
            col = from dat in dttUsuario.AsEnumerable()
                  where dat.Field<string>("Rol").Length == WidthText
                  select dat;

            GridViewTextBoxColumn colRol = new GridViewTextBoxColumn();
            colRol.FieldName = "Rol";
            colRol.HeaderText = "Rol";
            colRol.MinWidth = Consulta.AnchoTexto(WidthText > colRol.HeaderText.Length
                                            ? col.First().Field<string>("Rol").ToString()
                                            : colRol.HeaderText, RadGridViewUsuarios.Font);
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            RadGridViewUsuarios.Columns.Add(colRol);


            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewUsuarios.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewUsuarios.Columns.Add(colActivo);

            RadGridViewUsuarios.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewUsuarios_CurrentRowChanged);
        }

        protected void Habilita(bool estado)
        {
            RadTxtNombre.Enabled = estado;
            RadTxtApellido.Enabled = estado;
            RadTxtCodigo.Enabled = estado;
            RadTxtUsuario.Enabled = estado;
            RadTxtClave.Enabled = estado;
            RadTxtDocumento.Enabled = estado;
            RadTxtTelefono.Enabled = estado;
            RadTxtDireccion.Enabled = estado;
            RadDrpRol.Enabled = estado;
            RadChkActivo.Enabled = estado;
        }

        private void Limpia()
        {
            RadTxtNombre.Text = "";
            RadTxtApellido.Text = "";
            RadTxtCodigo.Text = "";
            RadTxtUsuario.Text = "";
            RadTxtClave.Text = "";
            RadTxtDocumento.Text = "";
            RadTxtTelefono.Text = "";
            RadTxtDireccion.Text = "";
            RadDrpRol.Text = "";
            RadDrpRol.SelectedIndex = -1;
            RadChkActivo.Checked = true;

        }

        private void cargaGrilla()
        {
            RadGridViewUsuarios.DataSource = dttUsuario;
        }

        private void RadGridViewUsuarios_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if(e.CurrentRow== null ? false : e.CurrentRow.Index>-1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.UsuarioID = int.Parse(dtsUsuario.Rows[RowIndex]["UsuarioID"].ToString());
            RadTxtNombre.Text = dttUsuario.Rows[RowIndex]["Nombre"].ToString();
            RadTxtApellido.Text = dttUsuario.Rows[RowIndex]["Apellido"].ToString();
            RadTxtCodigo.Text = dttUsuario.Rows[RowIndex]["CodigoUsuario"].ToString();
            RadTxtUsuario.Text = dttUsuario.Rows[RowIndex]["NombreUsuario"].ToString();
            RadTxtClave.Text = dttUsuario.Rows[RowIndex]["Clave"].ToString();
            RadTxtDocumento.Text = dttUsuario.Rows[RowIndex]["Documento"].ToString();
            RadTxtTelefono.Text = dttUsuario.Rows[RowIndex]["Telefono"].ToString();
            RadTxtDireccion.Text = dttUsuario.Rows[RowIndex]["Direccion"].ToString();
            RadDrpRol.SelectedValue = int.Parse(dttUsuario.Rows[RowIndex]["RolID"].ToString());
            RadChkActivo.Checked = bool.Parse(dttUsuario.Rows[RowIndex]["Activo"].ToString());

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
            RadGridViewUsuarios.Enabled = false;
            RadTxtNombre.Focus();
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            if (int.Parse(dttUsuario.Rows[RowIndex]["UsuarioID"].ToString()) != Program.User.UsuarioID)
            {
                Habilita(true);
                RadTxtNombre.Focus();
            }
            else
            {
                RadTxtClave.Enabled = true;
                RadTxtDireccion.Enabled = true;
                RadTxtDocumento.Enabled = true;
                RadTxtTelefono.Enabled = true;
                RadTxtClave.Focus();
            }

            RadMenuItemEditar.Enabled = false;
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewUsuarios.Enabled = false;
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            bool modifica = RowIndex > -1;

            if (ValidaCambios(modifica))
            {
                RadMessageBox.Show("No se han realizado cambios.","ALERTA");
                return;
            }

            if (RadMessageBox.Show("Seguro desea guardar la información suministrada?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (RadTxtNombre.Text == "" || RadTxtApellido.Text=="")
            {
                RadMessageBox.Show("Debes ingresar Nombre y Apellido del Usuario.", "ALERTA");
                return;
            }

            if (RadTxtCodigo.Text == "")
            {
                RadMessageBox.Show("Debes ingresar Código del Usuario.", "ALERTA");
                return;
            }

            if (RadTxtUsuario.Text == "" || RadTxtClave.Text=="")
            {
                RadMessageBox.Show("Debes ingresar Nombre de Usuario y su Clave.", "ALERTA");
                return;
            }

            if (RadDrpRol.SelectedIndex==-1)
            {
                RadMessageBox.Show("Debe seleccionar el Rol del Usuario.", "ALERTA");
                return;
            }

            if (Program.User.RolID>=int.Parse(RadDrpRol.SelectedValue.ToString()))
            {
                RadMessageBox.Show("Solo puede crear usuarios con roles inferiores.", "ALERTA");
                return;
            }



            Usuario User = new Usuario();
            User.UsuarioID = modifica  ? int.Parse(dttUsuario.Rows[RowIndex]["UsuarioID"].ToString()):0;
            User.Nombre = RadTxtNombre.Text;
            User.CodigoUsuario = RadTxtCodigo.Text;
            User.Apellido = RadTxtApellido.Text;
            User.NombreUsuario = RadTxtUsuario.Text;
            User.Clave = RadTxtClave.Text;
            User.Documento = RadTxtDocumento.Text;
            User.Telefono = RadTxtTelefono.Text;
            User.Direccion = RadTxtDireccion.Text;
            User.RolID = int.Parse(RadDrpRol.SelectedValue.ToString());
            User.Activo = RadChkActivo.Checked;

            DataSet dtsSave = Consulta.GuardaUsuario(modifica, User);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            dts = Consulta.ConsultaUsuario();
            TablaUsuario();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewUsuarios.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;

            if (modifica)
            {
                cont = RadTxtNombre.Text != dttUsuario.Rows[RowIndex]["Nombre"].ToString() ? (cont + 1) : cont;
                cont = RadTxtApellido.Text != dttUsuario.Rows[RowIndex]["Apellido"].ToString() ? (cont + 1) : cont;
                cont = RadTxtCodigo.Text != dttUsuario.Rows[RowIndex]["CodigoUsuario"].ToString() ? (cont + 1) : cont;
                cont = RadTxtUsuario.Text != dttUsuario.Rows[RowIndex]["NombreUsuario"].ToString() ? (cont + 1) : cont;
                cont = RadTxtClave.Text != dttUsuario.Rows[RowIndex]["Clave"].ToString() ? (cont + 1) : cont;
                cont = RadTxtDocumento.Text != dttUsuario.Rows[RowIndex]["Documento"].ToString() ? (cont + 1) : cont;
                cont = RadTxtTelefono.Text != dttUsuario.Rows[RowIndex]["Telefono"].ToString() ? (cont + 1) : cont;
                cont = RadTxtDireccion.Text != dttUsuario.Rows[RowIndex]["Direccion"].ToString() ? (cont + 1) : cont;
                cont = RadDrpRol.SelectedValue.ToString() != dttUsuario.Rows[RowIndex]["RolID"].ToString() ? (cont + 1) : cont;
                cont = RadChkActivo.Checked != bool.Parse(dttUsuario.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont; 
            }

            return modifica? cont == 0:modifica;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaUsuario();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewUsuarios.Enabled = true;
        }
    }
}
