using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Peluqueria.Clases;
using System.Globalization;
using System.Data;
using System.Collections;
using System.Diagnostics;
using System.Configuration;

namespace Peluqueria
{
    static class Program
    {

        public static Telerik.WinControls.Themes.Office2010BlackTheme ThemeOffice2007Black = new Telerik.WinControls.Themes.Office2010BlackTheme();
        public static Telerik.WinControls.Themes.Office2013DarkTheme ThemeOffice2013Dark = new Telerik.WinControls.Themes.Office2013DarkTheme();
        public static Telerik.WinControls.Themes.VisualStudio2012DarkTheme ThemeVisualStudio2012Dark = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
    
        public static Usuario User = new Usuario();
        public static DataTable dttForm = new DataTable();

        public static string NombreTema = Properties.Settings.Default.NombreTema.ToString();//ThemeOffice2007Black.ThemeName;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.CurrentCulture = new CultureInfo("en-US");
            Application.CurrentCulture.NumberFormat.PercentDecimalDigits = 0;
            Application.CurrentCulture.NumberFormat.NumberDecimalDigits = 0;
            //Application.CurrentCulture.NumberFormat.CurrencyDecimalDigits = 0;

            Application.Run(new RadFormLogin());

        }
    }
}
