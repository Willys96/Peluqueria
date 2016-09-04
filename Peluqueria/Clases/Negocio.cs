using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Management;
using System.Net.NetworkInformation;
using Telerik.WinControls;
using System.Net.Mail;
using System.Net;
using ExcelP = Microsoft.Office.Interop.Excel;
using System.IO;
using Peluqueria.Properties;

namespace Peluqueria.Clases
{
    class Negocio
    {
        #region Utilidades
        private const string Default8Key = "A9aWRHUB";
        private const string Default8VI = "k9x6MwU5";

        public string Cifrar(string Cadena)
        {
            byte[] PlainText;
            PlainText = Encoding.ASCII.GetBytes(Cadena);

            MemoryStream memdata = new MemoryStream();
            System.Security.Cryptography.DESCryptoServiceProvider DES = new System.Security.Cryptography.DESCryptoServiceProvider();
            System.Security.Cryptography.CryptoStream cryptostream = new System.Security.Cryptography.CryptoStream(memdata,
                DES.CreateEncryptor(Encoding.ASCII.GetBytes(Default8Key), Encoding.ASCII.GetBytes(Default8VI)),
                System.Security.Cryptography.CryptoStreamMode.Write);

            cryptostream.Write(PlainText, 0, PlainText.Length);
            cryptostream.FlushFinalBlock();
            cryptostream.Close();

            return Convert.ToBase64String(memdata.ToArray());

        }

        public string Descifrar(string Cadena)
        {
            try
            {
                if (string.IsNullOrEmpty(Cadena))
                    return Cadena;

                byte[] PlainText;
                PlainText = Convert.FromBase64String(Cadena);

                MemoryStream memdata = new MemoryStream();

                System.Security.Cryptography.DESCryptoServiceProvider DES = new System.Security.Cryptography.DESCryptoServiceProvider();
                System.Security.Cryptography.CryptoStream cryptostream = new System.Security.Cryptography.CryptoStream(memdata,
                    DES.CreateDecryptor(Encoding.ASCII.GetBytes(Default8Key), Encoding.ASCII.GetBytes(Default8VI)),
                    System.Security.Cryptography.CryptoStreamMode.Write);

                cryptostream.Write(PlainText, 0, PlainText.Length);
                cryptostream.FlushFinalBlock();
                cryptostream.Close();

                return Encoding.ASCII.GetString(memdata.ToArray());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataSet GetDts(string tSql, List<SqlParameter> param)
        {
            //string sconn = @"Data Source = W1LL1S\HOME; Initial Catalog = DBPeluqueria; user id = sa; password = willys";
            string sconn = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ToString();
            sconn = Descifrar(sconn);

            SqlConnection conn = new SqlConnection(sconn);
            SqlCommand cmd = new SqlCommand(tSql, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 30000000;

            for (int i = 0; i < param.Count; i++)
            {
                cmd.Parameters.Add(param[i]);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(dt);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
                return dt;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }

                DataTable dtt = new DataTable();
                dtt.Columns.Add("Resultado");
                dtt.Columns.Add("Mensaje");

                DataRow dtr = dtt.NewRow();
                dtr["Resultado"] = "0";
                dtr["Mensaje"] = ex.Message;

                dtt.Rows.Add(dtr);

                dt.Tables.Add(dtt);
                return dt;
            }

        }

        public int AnchoTexto(string texto, Font Fuente)
        {
            SizeF size;
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                size = g.MeasureString(texto, Fuente);
            }

            return Convert.ToInt32(size.Width + 15);
        }

        public int AnchoTexto(string texto, string texto1, Font Fuente)
        {
            SizeF size;
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                size = g.MeasureString(texto, Fuente);
            }

            SizeF size2;
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                size2 = g.MeasureString(texto1, Fuente);
            }

            return Convert.ToInt32(size2.Width + 25) >Convert.ToInt32(size.Width + 15)? Convert.ToInt32(size2.Width + 25): Convert.ToInt32(size.Width + 15);
        }

        public string ConsultarBoard()
        {
            string mbInfo = String.Empty;

            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            foreach (ManagementObject mo in mbs.Get())
            {
                try
                {
                    mbInfo += mo["SerialNumber"].ToString();
                }
                catch { }
            }
            return mbInfo;
        }

        public  string ConsultarMac()
        {
            string processorID = "";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "Select * FROM WIN32_Processor");

            ManagementObjectCollection mObject = searcher.Get();

            foreach (ManagementObject obj in mObject)
            {
                processorID = obj["ProcessorId"].ToString();
            }

            return processorID;
        }

        public void FusionTablas(DataSet dtsReporte, DataSet dtsOrigen, string accion,DateTime inicio,DateTime final)
        {
            DataTable dtt = new DataTable();



            for (int l = 1; l < dtsOrigen.Tables.Count; l++)
            {
                if (l == 1)
                {
                    dtt = dtsOrigen.Tables[l].Copy();

                    foreach (DataColumn col in dtsOrigen.Tables[l].Columns)
                    {
                        if (col.ColumnName.Contains("ID"))
                        {
                            dtt.Columns.Remove(dtt.Columns[col.ColumnName]);
                        }
                    }
                }
                else
                {
                    foreach (DataColumn col in dtsOrigen.Tables[l].Columns)
                    {

                        if (!col.ColumnName.Contains("ID"))
                        {
                            string add = dtt.Columns.IndexOf(col.ColumnName) > -1 ? "X" : "";

                            try
                            {
                                dtt.Columns.Add(col.ColumnName + add);
                            }
                            catch (Exception)
                            {

                                add = dtt.Columns.IndexOf(col.ColumnName) > -1 ? "XX" : "";
                                dtt.Columns.Add(col.ColumnName + add);
                            }

                            col.ColumnName += add;
                        }
                    }


                    if (dtt.Rows.Count > 0)
                    {
                        for (int k = 0; k < dtsOrigen.Tables[l].Rows.Count; k++)
                        {
                            DataRow dtr = dtt.NewRow();

                            for (int j = 0; j < dtsOrigen.Tables[l].Columns.Count; j++)
                            {

                                if (!dtsOrigen.Tables[l].Columns[j].ColumnName.Contains("ID"))
                                {
                                    if (k < dtt.Rows.Count)
                                    {
                                        dtt.Rows[k][dtsOrigen.Tables[l].Columns[j].ColumnName] = dtsOrigen.Tables[l].Rows[k][dtsOrigen.Tables[l].Columns[j].ColumnName].ToString();
                                    }
                                    else
                                    {
                                        dtr[dtsOrigen.Tables[l].Columns[j].ColumnName] = dtsOrigen.Tables[l].Rows[k][dtsOrigen.Tables[l].Columns[j].ColumnName].ToString();

                                        if (j == (dtsOrigen.Tables[l].Columns.Count - 1))
                                        {
                                            dtt.Rows.Add(dtr);
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            }

            switch (accion)
            {
                case "0":
                    dtt.TableName = inicio !=final
                                    ? "Ventas(" + inicio.ToString("yyyyMMdd") + "-" +final.ToString("yyyyMMdd") + ")"
                                    : "Ventas(" + inicio.ToString("yyyyMMdd") + ")";
                    break;
                case "1":
                    dtt.TableName = inicio.Date !=final.Date
                                    ? "Nomina(" + inicio.ToString("yyyyMMdd") + "-" +final.ToString("yyyyMMdd") + ")"
                                    : "Nomina(" + inicio.ToString("yyyyMMdd") + ")";

                    break;
                case "2":
                    dtt.TableName = "Inventario";
                    break;

            }

            for (int l = 0; l < dtt.Rows.Count; l++)
            {
                for (int j = 0; j < dtt.Columns.Count; j++)
                {
                    if (dtt.Rows[l][j].ToString() == "")
                    {
                        dtt.Rows[l][j] = dtt.Rows[0][j].GetType().Name == "Int32" ? "0" : "...";
                    }
                }
            }

            dtsReporte.Tables.Add(dtt);
        }

        public void GeneraExcelMultiplePagina(string pathFile)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                #region Ventas
                DataSet venta = ConsultaVentas(0, DateTime.Today.AddDays(-1).ToString("yyyyMMdd"), DateTime.Today.AddDays(-1).ToString("yyyyMMdd"));
                FusionTablas(dsConsulta, venta, "0", DateTime.Today.AddDays(-1), DateTime.Today.AddDays(-1));

                if (DateTime.Today.DayOfWeek.ToString() == "Monday")
                {
                    venta = ConsultaVentas(0, DateTime.Today.AddDays(-7).ToString("yyyyMMdd"), DateTime.Today.AddDays(-1).ToString("yyyyMMdd"));
                    FusionTablas(dsConsulta, venta, "0", DateTime.Today.AddDays(-7), DateTime.Today.AddDays(-1));
                }

                if (DateTime.Today.Day == 1)
                {
                    venta = ConsultaVentas(0, DateTime.Today.AddMonths(-1).ToString("yyyyMMdd"), DateTime.Today.AddDays(-1).ToString("yyyyMMdd"));
                    FusionTablas(dsConsulta, venta, "0", DateTime.Today.AddMonths(-1), DateTime.Today.AddDays(-1));
                }
                #endregion

                #region Nomina
                DataSet nomina = ConsultaVentas(1, DateTime.Today.AddDays(-1).ToString("yyyyMMdd"), DateTime.Today.AddDays(-1).ToString("yyyyMMdd"));
                FusionTablas(dsConsulta, venta, "1", DateTime.Today.AddDays(-1), DateTime.Today.AddDays(-1));

                if (DateTime.Today.DayOfWeek.ToString() == "Monday")
                {
                    nomina = ConsultaVentas(1, DateTime.Today.AddDays(-7).ToString("yyyyMMdd"), DateTime.Today.AddDays(-1).ToString("yyyyMMdd"));
                    FusionTablas(dsConsulta, nomina, "1", DateTime.Today.AddDays(-7), DateTime.Today.AddDays(-1));
                }

                if (DateTime.Today.Day == 1)
                {
                    nomina = ConsultaVentas(1, DateTime.Today.AddMonths(-1).ToString("yyyyMMdd"), DateTime.Today.AddDays(-1).ToString("yyyyMMdd"));
                    FusionTablas(dsConsulta, nomina, "1", DateTime.Today.AddMonths(-1), DateTime.Today.AddDays(-1));
                }
                #endregion

                #region Inventario
                DataSet inven = ConsultaInventario();
                FusionTablas(dsConsulta, inven, "2", DateTime.Today, DateTime.Today);
                #endregion

                List<SqlParameter> parametros = new List<SqlParameter>();

                object misValue = System.Reflection.Missing.Value;
                ExcelP.Application Excel = new ExcelP.Application();
                ExcelP.Workbooks LibrosExcel = Excel.Workbooks;
                ExcelP.Workbook LibroExcel = LibrosExcel.Add();
                ExcelP.Worksheet HojaExcel;

                LibroExcel = Excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                int worksheetIndex = 0;
                foreach (DataTable dt in dsConsulta.Tables)
                {
                    worksheetIndex++;

                    if (worksheetIndex == 1)
                    {
                        HojaExcel = LibroExcel.Worksheets.get_Item(1);
                    }
                    else
                    {
                        HojaExcel = LibroExcel.Worksheets.Add();
                    }

                    HojaExcel.Name = dt.TableName;

                    #region nombreColumnas
                    HojaExcel.Range["A1:" + letraTitulo(dt.Columns.Count - 1) + "1"].Font.Bold = true;
                    HojaExcel.Range["A1:" + letraTitulo(dt.Columns.Count - 1) + "1"].Font.Size = 12;

                    Microsoft.Office.Interop.Excel.Range objCelda;//= HojaExcel.Range["A1", Type.Missing];

                    int contcol = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        objCelda = HojaExcel.Range[letraTitulo(contcol) + "1", Type.Missing];
                        objCelda.Value = col.ColumnName.Replace("X","");
                        contcol++;
                    }

                    objCelda = null;
                    #endregion


                    #region setdatos
                    int rowIndex = 2;
                    foreach (DataRow row in dsConsulta.Tables[worksheetIndex - 1].Rows)
                    {
                        int columnIndex = 1;

                        foreach (object dc in row.ItemArray)
                        {
                            HojaExcel.Cells[rowIndex, columnIndex] = dc.ToString();
                            columnIndex++;
                        }
                        rowIndex++;
                    }
                    #endregion

                    objCelda = HojaExcel.Range["A1:" + letraTitulo(dt.Columns.Count - 1) + (rowIndex - 1).ToString()];
                    objCelda.Columns.AutoFit(); objCelda = null;


                }

                Excel.Cells.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                LibroExcel.SaveAs(pathFile, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);

                LibroExcel.Close(true, misValue, misValue);
                Excel.UserControl = false;
                Excel.Quit();

                releaseObject(LibroExcel);
                releaseObject(LibrosExcel);
                releaseObject(Excel);

            }
            catch (Exception ex)
            {
            }

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        protected string letraTitulo(int contcol)
        {
            string celda = "";
            switch (contcol)
            {
                case 0:
                    celda = "A";
                    break;
                case 1:
                    celda = "B";
                    break;
                case 2:
                    celda = "C";
                    break;
                case 3:
                    celda = "D";
                    break;
                case 4:
                    celda = "E";
                    break;
                case 5:
                    celda = "F";
                    break;
                case 6:
                    celda = "G";
                    break;
                case 7:
                    celda = "H";
                    break;
                case 8:
                    celda = "I";
                    break;
                case 9:
                    celda = "J";
                    break;
                case 10:
                    celda = "K";
                    break;
                case 11:
                    celda = "L";
                    break;
                case 12:
                    celda = "M";
                    break;
                case 13:
                    celda = "N";
                    break;
                case 14:
                    celda = "O";
                    break;
                case 15:
                    celda = "P";
                    break;
                case 16:
                    celda = "Q";
                    break;
                case 17:
                    celda = "R";
                    break;
                case 18:
                    celda = "S";
                    break;
                case 19:
                    celda = "T";
                    break;
                case 20:
                    celda = "U";
                    break;
                case 21:
                    celda = "V";
                    break;
                case 22:
                    celda = "W";
                    break;
                case 23:
                    celda = "X";
                    break;
                case 24:
                    celda = "Y";
                    break;
                case 25:
                    celda = "Z";
                    break;
                case 26:
                    celda = "AA";
                    break;
                case 27:
                    celda = "AB";
                    break;
                case 28:
                    celda = "AC";
                    break;
                case 29:
                    celda = "AD";
                    break;
                case 30:
                    celda = "AE";
                    break;
                case 31:
                    celda = "AF";
                    break;
                case 32:
                    celda = "AG";
                    break;
                case 33:
                    celda = "AH";
                    break;
                case 34:
                    celda = "AI";
                    break;
                case 35:
                    celda = "AJ";
                    break;
                case 36:
                    celda = "AK";
                    break;
                case 37:
                    celda = "AL";
                    break;
                case 38:
                    celda = "AM";
                    break;
                case 39:
                    celda = "AN";
                    break;
                case 40:
                    celda = "AO";
                    break;
                    break;




            }
            return celda;
        }

        public DataSet ConsultaLicencia(string Board, string Mac)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Board", Board));
            parametros.Add(new SqlParameter("@Mac", Mac));
            DataSet dtscan = GetDts("SpConsultaLicencia", parametros);
            return dtscan;
        }

        public DataSet InsertaLicencia()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Board", ConsultarBoard()));
            parametros.Add(new SqlParameter("@Mac", ConsultarMac()));
            DataSet dtscan = GetDts("SpInsertaLicencia", parametros);
            return dtscan;
        }
        #endregion

        #region Usuario
        public DataSet ConsultaUsuarioLogin(string NombreUsuario, string Clave)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@NombreUsuario", NombreUsuario));
            parametros.Add(new SqlParameter("@Clave", Clave));
            DataSet dtscan = GetDts("SpConsultaUsuarioLogin", parametros);
            return dtscan;
        }

        public DataSet ConsultaUsuario()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataSet dtscan = GetDts("SpConsultaUsuario", parametros);

            return dtscan;
        }

        public DataSet GuardaUsuario(bool Modifica, Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@UsuarioID", user.UsuarioID));
            parametros.Add(new SqlParameter("@Nombre", user.Nombre));
            parametros.Add(new SqlParameter("@Apellido", user.Apellido));
            parametros.Add(new SqlParameter("@CodigoUsuario", user.CodigoUsuario));
            parametros.Add(new SqlParameter("@NombreUsuario", user.NombreUsuario));
            parametros.Add(new SqlParameter("@Clave", user.Clave));
            parametros.Add(new SqlParameter("@Documento", user.Documento));
            parametros.Add(new SqlParameter("@Telefono", user.Telefono));
            parametros.Add(new SqlParameter("@Direccion", user.Direccion));
            parametros.Add(new SqlParameter("@RolID", user.RolID));
            parametros.Add(new SqlParameter("@Activo", user.Activo));
            parametros.Add(new SqlParameter(Modifica ? "@UsuarioModificaID" : "@UsuarioCreaID", Program.User.UsuarioID));
            DataSet dtscan = GetDts(Modifica ? "SpModificaUsuario" : "SpCreaUsuario", parametros);

            return dtscan;
        }
        #endregion

        #region Productos y Servicios

        public DataSet ConsultaProductosServicios()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataSet dtscan = GetDts("SpConsultaProductosServicios", parametros);

            return dtscan;
        }

        public DataSet GuardaProducto(bool Modifica, Producto Product)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ProductoID", Product.ProductoID));
            parametros.Add(new SqlParameter("@Nombre", Product.Nombre));
            parametros.Add(new SqlParameter("@UnidadxProducto", Product.UnidadxProducto));
            parametros.Add(new SqlParameter("@ValorCompra", Product.ValorCompra));
            parametros.Add(new SqlParameter("@ValorVentaXUnidad", Product.ValorVentaXUnidad));
            parametros.Add(new SqlParameter("@PorcentajeVentaPublico", Product.PorcentajeVentaPublico));
            parametros.Add(new SqlParameter("@DescuentoVentaInterna", Product.DescuentoVentaInterna));
            parametros.Add(new SqlParameter("@Insumo", Product.Insumo));
            parametros.Add(new SqlParameter("@CodigoProducto", Product.CodigoProducto));
            parametros.Add(new SqlParameter("@Activo", Product.Activo));
            parametros.Add(new SqlParameter(Modifica ? "@UsuarioModificaID" : "@UsuarioCreaID", Program.User.UsuarioID));
            parametros.Add(new SqlParameter("@ProveedorID", Product.ProveedorID));
            DataSet dtscan = GetDts(Modifica ? "SpModificaProducto" : "SpCreaProducto", parametros);

            return dtscan;
        }

        public DataSet ConsultaServicio()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataSet dtscan = GetDts("SpConsultaServicio", parametros);

            return dtscan;
        }

        public DataSet GuardaServicio(bool Modifica, Servicio Service)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ServicioID", Service.ServicioID));
            parametros.Add(new SqlParameter("@Nombre", Service.Nombre));
            parametros.Add(new SqlParameter("@ValorVenta", Service.ValorVenta));
            parametros.Add(new SqlParameter("@PorcentajeEstilista", Service.PorcentajeEstilista));
            parametros.Add(new SqlParameter("@Variable", Service.Variable));
            parametros.Add(new SqlParameter("@CodigoServicio", Service.CodigoServicio));
            parametros.Add(new SqlParameter("@Activo", Service.Activo));
            parametros.Add(new SqlParameter(Modifica ? "@UsuarioModificaID" : "@UsuarioCreaID", Program.User.UsuarioID));
            DataSet dtscan = GetDts(Modifica ? "SpModificaServicio" : "SpCreaServicio", parametros);

            return dtscan;
        }
        #endregion

        #region Inventario
        public DataSet ConsultaInventario()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataSet dtscan = GetDts("SpConsultaInventario", parametros);

            return dtscan;
        }

        public DataSet ModificaInventario(int ProductoID, int CantidadUnidad,bool Adiciona)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ProductoID", ProductoID));
            parametros.Add(new SqlParameter("@CantidadUnidad", CantidadUnidad));
            parametros.Add(new SqlParameter("@UsuarioID", Program.User.UsuarioID));
            parametros.Add(new SqlParameter("@Adiciona", Adiciona));
            parametros.Add(new SqlParameter("@return", true));
            DataSet dtscan = GetDts("SpModificaInventario", parametros);
            return dtscan;
        }
        #endregion

        #region Ventas
        public DataSet ConsultaProducto()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataSet dtscan = GetDts("SpConsultaProducto", parametros);

            return dtscan;
        }

        public DataSet CreaVenta(string XmlVenta, int ValorTotal,bool Interna)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@XmlVenta", XmlVenta));
            parametros.Add(new SqlParameter("@ValorTotal", ValorTotal));
            parametros.Add(new SqlParameter("@UsuarioCreaID", Program.User.UsuarioID));
            parametros.Add(new SqlParameter("@Interna", Interna));
            DataSet dtscan = GetDts("SpCreaVenta", parametros);
            return dtscan;
        }

        public DataSet EliminaVenta(int VentaID)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@VentaID", VentaID));
            parametros.Add(new SqlParameter("@UsuarioID", Program.User.UsuarioID));
            DataSet dtscan = GetDts("SpModificaVenta", parametros);
            return dtscan;
        }

        public DataSet ConsultaVentas(int TipoReporte,string FechaInicial, string FechaFinal)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@TipoReporte", TipoReporte));
            parametros.Add(new SqlParameter("@FechaInicial", FechaInicial));
            parametros.Add(new SqlParameter("@FechaFinal", FechaFinal));
            DataSet dtscan = GetDts("SpConsultaVentas", parametros);
            return dtscan;
        }


        #endregion

        #region Correo
        protected DataSet ConsultaCorreo()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataSet dtscan = GetDts("SpConsultaCorreo", parametros);

            return dtscan;
        }
        public void Correo(string mensaje,string[] Ajuntos)
        {
            DataSet dtscorreo = ConsultaCorreo();

            if (!(dtscorreo.Tables[0].Rows[0]["Resultado"].ToString()=="1"))
            {
                RadMessageBox.Show(dtscorreo.Tables[0].Rows[0]["Resultado"].ToString(), "ALERTA");
                return;
            }

            var origen = from org in dtscorreo.Tables[1].AsEnumerable()
                         where org.Field<bool>("Origen") == true
                         select org;

            var destino = from des in dtscorreo.Tables[1].AsEnumerable()
                         where des.Field<bool>("Origen") == false
                         select des;

            foreach (DataRow dtr in origen.CopyToDataTable().Copy().Rows)
            {

                foreach (DataRow dtr1 in destino.CopyToDataTable().Copy().Rows)
                {

                    MailMessage email = new MailMessage();
                    email.To.Add(new MailAddress(dtr1["Cuenta"].ToString()));
                    email.From = new MailAddress(dtr["Cuenta"].ToString());

                    foreach (var ruta in Ajuntos)
                    {
                        email.Attachments.Add(new Attachment(ruta));
                    }

                    email.Subject = "Reporte Diario [Peluqueria Calderon Ortiz]";
                    email.Body = mensaje;
                    email.IsBodyHtml = true;
                    email.Priority = MailPriority.High;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = dtr["Servidor"].ToString();
                    smtp.Port = int.Parse(dtr["Puerto"].ToString());
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(dtr["Cuenta"].ToString(), dtr["Contrasenha"].ToString());
                    smtp.EnableSsl = true;

                    string output = null;

                    try
                    {
                        smtp.Send(email);
                        email.Dispose();
                        output = "Correo electrónico fue enviado satisfactoriamente.";
                    }
                    catch (Exception ex)
                    {
                        output = "Error enviando correo electrónico: " + ex.Message;

                    }
                }
            }

            //return output;

        }
        #endregion

        #region Adelantos/Incentivo - Gastos - Depositos - Pago de Facturas

        public DataSet ConsultaAdelantoInsentivo(string FechaInicial, string FechaFinal)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@FechaInicial", FechaInicial));
            parametros.Add(new SqlParameter("@FechaFinal", FechaFinal));
            DataSet dtscan = GetDts("SpConsultaAdelantoInsentivo", parametros);

            return dtscan;
        }

        public DataSet ConsultaDeposito(string FechaInicial, string FechaFinal)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@FechaInicial", FechaInicial));
            parametros.Add(new SqlParameter("@FechaFinal", FechaFinal));
            DataSet dtscan = GetDts("SpConsultaDeposito", parametros);

            return dtscan;
        }

        public DataSet ConsultaGasto(string FechaInicial, string FechaFinal)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@FechaInicial", FechaInicial));
            parametros.Add(new SqlParameter("@FechaFinal", FechaFinal));
            DataSet dtscan = GetDts("SpConsultaGasto", parametros);

            return dtscan;
        }

        public DataSet ConsultaPagoFactura(string FechaInicial, string FechaFinal)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@FechaInicial", FechaInicial));
            parametros.Add(new SqlParameter("@FechaFinal", FechaFinal));
            DataSet dtscan = GetDts("SpConsultaPagoFactura", parametros);

            return dtscan;
        }

        public DataSet GuardaAdelantoInsentivo(bool Modifica, AdelantoInsentivo AdelInsen)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@AdelantoInsentivoID", AdelInsen.AdelantoInsentivoID));
            parametros.Add(new SqlParameter("@UsuarioAdelantoInsentivoID", AdelInsen.UsuarioAdelantoInsentivoID));
            parametros.Add(new SqlParameter("@ValorAdelantoInsentivo", AdelInsen.ValorAdelantoInsentivo));
            parametros.Add(new SqlParameter("@Adelanto", AdelInsen.Adelanto));
            parametros.Add(new SqlParameter("@Activo", AdelInsen.Activo));
            parametros.Add(new SqlParameter(Modifica ? "@UsuarioModificaID" : "@UsuarioCreaID", Program.User.UsuarioID));
            DataSet dtscan = GetDts(Modifica ? "SpModificaAdelantoInsentivo" : "SpCreaAdelantoInsentivo", parametros);

            return dtscan;
        }

        public DataSet GuardaDeposito(bool Modifica, Deposito Depos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@DepositoID", Depos.DepositoID));
            parametros.Add(new SqlParameter("@ValorDeposito", Depos.ValorDeposito));
            parametros.Add(new SqlParameter("@Activo", Depos.Activo));
            parametros.Add(new SqlParameter(Modifica ? "@UsuarioModificaID" : "@UsuarioCreaID", Program.User.UsuarioID));
            DataSet dtscan = GetDts(Modifica ? "SpModificaDeposito" : "SpCreaDeposito", parametros);

            return dtscan;
        }

        public DataSet GuardaGasto(bool Modifica, Gasto Gast)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@GastoID", Gast.GastoID));
            parametros.Add(new SqlParameter("@Detalle", Gast.Detalle));
            parametros.Add(new SqlParameter("@ValorGasto", Gast.ValorGasto));
            parametros.Add(new SqlParameter("@Activo", Gast.Activo));
            parametros.Add(new SqlParameter(Modifica ? "@UsuarioModificaID" : "@UsuarioCreaID", Program.User.UsuarioID));
            DataSet dtscan = GetDts(Modifica ? "SpModificaGasto" : "SpCreaGasto", parametros);

            return dtscan;
        }

        public DataSet GuardaPagoFactura(bool Modifica, PagoFactura PagFac)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@PagoFacturaID", PagFac.PagoFacturaID));
            parametros.Add(new SqlParameter("@ProveedorID", PagFac.ProveedorID));
            parametros.Add(new SqlParameter("@NumeroFactura", PagFac.NumeroFactura));
            parametros.Add(new SqlParameter("@ValorPagoFactura", PagFac.ValorPagoFactura));
            parametros.Add(new SqlParameter("@Activo", PagFac.Activo));
            parametros.Add(new SqlParameter(Modifica ? "@UsuarioModificaID" : "@UsuarioCreaID", Program.User.UsuarioID));
            DataSet dtscan = GetDts(Modifica ? "SpModificaPagoFactura" : "SpCreaPagoFactura", parametros);

            return dtscan;
        }

        #endregion
    }
}
