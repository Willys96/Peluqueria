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
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Configuration;

namespace Licencia
{
    public class Negocio
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
    }
}
