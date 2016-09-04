using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Linq;
using System.Collections;

namespace Peluqueria
{
    public partial class RadRibbonFormMain : Telerik.WinControls.UI.RadRibbonForm
    {
        public RadRibbonFormMain()
        {
            InitializeComponent();
            this.RadButtonElementUsuarios.Click += new System.EventHandler(this.RadButtonElementUsuarios_Click);

            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            this.RadMenuComboItemTheme.ComboBoxElement.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.RadMenuComboItemTheme_ComboBoxElement_SelectedIndexChanged);
            this.Text += " - [Usuario: " + Program.User.Nombre + " " + Program.User.Apellido+"]";
        }

        protected bool ValidaForm(string FormName)
        {
            var Forma = from formas in this.MdiChildren
                        where formas.Name == FormName
                        select formas;
            if(Forma.Count() > 0)
            {
                Forma.First().WindowState = FormWindowState.Normal;
                Forma.First().Show();
                Forma.First().Select();
            }

            return Forma.Count() > 0;
        }

        protected bool ValidaPermiso(string FormName)
        {
            var formi = from fro in Program.dttForm.AsEnumerable()
                        where fro.Field<string>("Nombre") == FormName
                        select fro;

            return formi.Count() > 0;
        }

        private void RadButtonElementUsuarios_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormUsuarios") && ValidaPermiso("RadFormUsuarios"))
            {
                RadFormUsuarios Usuarios = new RadFormUsuarios();
                Usuarios.WindowState = FormWindowState.Normal;
                Usuarios.MdiParent = this;
                Usuarios.Show();
            }
        }

        private void RadButtonElementProductos_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormProductos") && ValidaPermiso("RadFormProductos"))
            {
                RadFormProductos Productos = new RadFormProductos();
                Productos.WindowState = FormWindowState.Normal;
                Productos.MdiParent = this;
                Productos.Show();
            }
        }

        private void RadButtonElementSERVICIOS_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormServicios") && ValidaPermiso("RadFormServicios"))
            {
                RadFormServicios Servicios = new RadFormServicios();
                Servicios.WindowState = FormWindowState.Normal;
                Servicios.MdiParent = this;
                Servicios.Show();
            }
        }

        private void RadButtonElementFACTURACION_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormVentas") && ValidaPermiso("RadFormVentas"))
            {
                RadFormVentas Venta = new RadFormVentas();
                Venta.WindowState = FormWindowState.Normal;
                Venta.MdiParent = this;
                Venta.Show();

            }
        }

        private void RadRibbonFormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ArrayList formn = new System.Collections.ArrayList(System.Windows.Forms.Application.OpenForms);

            var login = from log in formn.ToArray()
                        where ((Form)log).Name=="RadFormLogin"
                        select log;

            if (login.Count() > 0)
            {
                ((Form)login.First()).Close();
            }

        }

        private void RadMenuComboItemTheme_ComboBoxElement_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(RadMenuComboItemTheme.ComboBoxElement.SelectedIndex>-1)
            {
                switch (RadMenuComboItemTheme.ComboBoxElement.SelectedIndex)
                {
                    
                    case 0:
                        Program.NombreTema = Program.ThemeOffice2007Black.ThemeName;
                        Properties.Settings.Default.NombreTema = Program.ThemeOffice2007Black.ThemeName;
                        break;

                    default:
                    case 1:
                        Program.NombreTema = Program.ThemeVisualStudio2012Dark.ThemeName;
                        Properties.Settings.Default.NombreTema = Program.ThemeVisualStudio2012Dark.ThemeName;
                        break;
                }

                this.RadMenuComboItemTheme.ComboBoxElement.SelectedIndexChanged -= new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.RadMenuComboItemTheme_ComboBoxElement_SelectedIndexChanged);

                ArrayList formn = new System.Collections.ArrayList(System.Windows.Forms.Application.OpenForms);

                foreach(Form formu in formn)
                {
                    ThemeResolutionService.ApplyThemeToControlTree(formu, Program.NombreTema);
                }

                this.RadMenuComboItemTheme.ComboBoxElement.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.RadMenuComboItemTheme_ComboBoxElement_SelectedIndexChanged);
                
            }

        }

        private void RadButtonElementGestion_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormInventario") && ValidaPermiso("RadFormInventario"))
            {
                RadFormInventario Gestion = new RadFormInventario();
                Gestion.WindowState = FormWindowState.Normal;
                Gestion.MdiParent = this;
                Gestion.Show();
            }
        }

        private void RadButtonElementReportes_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormReporte") && ValidaPermiso("RadFormReporte"))
            {
                RadFormReporte Reporte = new RadFormReporte();
                Reporte.WindowState = FormWindowState.Normal;
                Reporte.MdiParent = this;
                Reporte.Show();
            }
        }

        private void RadButtonElementAdelantoInsentivo_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormAdelantoInsentivo") && ValidaPermiso("RadFormAdelantoInsentivo"))
            {
                RadFormAdelantoInsentivo Reporte = new RadFormAdelantoInsentivo();
                Reporte.WindowState = FormWindowState.Normal;
                Reporte.MdiParent = this;
                Reporte.Show();
            }
        }

        private void RadButtonElementDesposito_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormDeposito") && ValidaPermiso("RadFormDeposito"))
            {
                RadFormDeposito Reporte = new RadFormDeposito();
                Reporte.WindowState = FormWindowState.Normal;
                Reporte.MdiParent = this;
                Reporte.Show();
            }
        }

        private void RadButtonElementGasto_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormGasto") && ValidaPermiso("RadFormGasto"))
            {
                RadFormGasto Reporte = new RadFormGasto();
                Reporte.WindowState = FormWindowState.Normal;
                Reporte.MdiParent = this;
                Reporte.Show();
            }
        }

        private void RadButtonElementPagoFactura_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormPagoFactura") && ValidaPermiso("RadFormPagoFactura"))
            {
                RadFormPagoFactura Reporte = new RadFormPagoFactura();
                Reporte.WindowState = FormWindowState.Normal;
                Reporte.MdiParent = this;
                Reporte.Show();
            }
        }

        private void RadButtonElementProveedor_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormProveedor") && ValidaPermiso("RadFormProveedor"))
            {
                RadFormProveedor Reporte = new RadFormProveedor();
                Reporte.WindowState = FormWindowState.Normal;
                Reporte.MdiParent = this;
                Reporte.Show();
            }
        }

        private void RadButtonElementCliente_Click(object sender, EventArgs e)
        {
            if (!ValidaForm("RadFormCliente") && ValidaPermiso("RadFormCliente"))
            {
                RadFormCliente Reporte = new RadFormCliente();
                Reporte.WindowState = FormWindowState.Normal;
                Reporte.MdiParent = this;
                Reporte.Show();
            }
        }
    }
}
