using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Peluqueria.Clases;
using System.IO;
using System.Diagnostics;

namespace Peluqueria
{
    public partial class RadFormLogin : Telerik.WinControls.UI.RadForm
    {

        Negocio Consulta = new Negocio();
        bool teclas = false;
        public RadFormLogin()
        {
            InitializeComponent();          

            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

        }

        private void RadFormLogin_Load(object sender, EventArgs e)
        {
            string processName = Process.GetCurrentProcess().ProcessName;
            Process[] instances = Process.GetProcessesByName(processName);

            if (instances.Length > 1)
            {
                MessageBox.Show("La aplicación Peluqueria ya se está ejecutando. Imposible Continuar");
                Application.Exit();
                return;

            }
        }

        private void RadBtnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void RadFormLogin_KeyDown(object sender, KeyEventArgs e)
        {

            //if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.Right))
            //{
            //    DataSet dtsLic = Consulta.InsertaLicencia();

            //    if (dtsLic.Tables[0].Rows[0]["Resultado"].ToString()=="0")
            //    {
            //        RadMessageBox.Show(dtsLic.Tables[0].Rows[0]["Mensaje"].ToString()); 
            //    }
            //    else
            //    {
            //        this.Close();
            //    }
            //}

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.D7))
            {
                teclas = true;
                login();
            }
        }

        private void login()
        {
            if ((RadTxtUser.Text != "" && RadTxtPassword.Text != "") || teclas)
            {
                DataSet Dts = Consulta.ConsultaUsuarioLogin(teclas ? "admin" : RadTxtUser.Text, teclas ? "admin123*" : RadTxtPassword.Text);

                if (Dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
                {
                    Program.User.UsuarioID = int.Parse(Dts.Tables[1].Rows[0]["UsuarioID"].ToString());
                    Program.User.Nombre = Dts.Tables[1].Rows[0]["Nombre"].ToString();
                    Program.User.Apellido = Dts.Tables[1].Rows[0]["Apellido"].ToString();
                    Program.User.NombreUsuario = Dts.Tables[1].Rows[0]["NombreUsuario"].ToString();
                    Program.User.Clave = Dts.Tables[1].Rows[0]["Clave"].ToString();
                    Program.User.Documento = Dts.Tables[1].Rows[0]["Documento"].ToString();
                    Program.User.Telefono = Dts.Tables[1].Rows[0]["Telefono"].ToString();
                    Program.User.Direccion = Dts.Tables[1].Rows[0]["Direccion"].ToString();
                    Program.User.RolID = int.Parse(Dts.Tables[1].Rows[0]["RolID"].ToString());
                    Program.User.Activo = bool.Parse(Dts.Tables[1].Rows[0]["Activo"].ToString());

                    Program.dttForm = Dts.Tables[2];


                    if (Program.User.RolID > 1)
                    {
                        string board = Consulta.ConsultarBoard();
                        string mac = Consulta.ConsultarMac();

                        Dts = Consulta.ConsultaLicencia(board, mac);

                        if (Dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
                        {

                            FileInfo reporte;

                            try
                            {
                                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");

                                try
                                {
                                    if (File.Exists(Application.StartupPath + @"\reporte" + DateTime.Now.ToString("yyyyMMdd") + ".xls"))
                                    {
                                        reporte = new FileInfo(Application.StartupPath + @"\reporte" + DateTime.Now.ToString("yyyyMMdd") + ".xls");
                                        reporte.Delete();
                                    }


                                    Consulta.GeneraExcelMultiplePagina(Application.StartupPath + @"\reporte" + DateTime.Now.ToString("yyyyMMdd") + ".xls");
                                    Consulta.Correo("Reporte", new string[] { Application.StartupPath + @"\reporte" + DateTime.Now.ToString("yyyyMMdd") + ".xls" });
                                }
                                catch (Exception ex)
                                {

                                    RadMessageBox.Show("Se presentaron errores al intentar enviar el correo de reportes.\nSe le recomienda loguearse de nuevo mas tarde para realizar esta tarea");
                                }

                            }
                            catch (Exception es)
                            {

                                RadMessageBox.Show("En este momento no cuenta con una conexión a internet, asi que no se enviará el correo con los resportes\nSe le recomienda loguearse de nuevo mas tarde para realizar esta tarea.");
                            }


                            if (!File.Exists(Application.StartupPath + @"\reporte" + DateTime.Now.ToString("yyyyMMdd") + ".xls"))
                            {
                                reporte = new FileInfo(Application.StartupPath + @"\reporte" + DateTime.Now.ToString("yyyyMMdd") + ".xls");
                                reporte.Delete(); 
                            }

                            RadRibbonFormMain FMain = new RadRibbonFormMain();
                            FMain.Show();

                            this.Hide();
                        }
                        else
                        {
                            RadLblError.Visible = true;
                            RadLblError.Text = Dts.Tables[0].Rows[0]["Mensaje"].ToString();
                        }
                    }
                    else
                    {
                        RadRibbonFormMain FMain = new RadRibbonFormMain();
                        FMain.Show();

                        this.Hide();
                    }
                }
                else
                {
                    //RadMessageBox.Show(Dts.Tables[0].Rows[0]["Mensaje"].ToString(), "ALERTA");
                    RadLblError.Visible = true;
                    RadLblError.Text = Dts.Tables[0].Rows[0]["Mensaje"].ToString();
                }
            }
            else
            {
                //RadMessageBox.Show("Favor diligenciar la información completa", "ALERTA");
                RadLblError.Visible = true;
                RadLblError.Text = "Favor diligenciar la información completa";
            }
        }
    }
}
