using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Licencia;
using System.Data;
using System.Data.SqlClient;

namespace Licencia
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Negocio consulta = new Negocio();

            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Validador de Licencias");
            Console.WriteLine("Precione la tecla Escape (Esc) para salir \n");

            DataSet dts = consulta.InsertaLicencia();//ConsultaLicencia(consulta.ConsultarBoard(),consulta.ConsultarMac());

            Console.WriteLine(dts.Tables[0].Rows[0]["Mensaje"].ToString()+"\n");

            Console.WriteLine("Proceso finalizado...");

            //do
            //{
            //    cki = Console.ReadKey();

            ////    //if ((cki.Modifiers & ConsoleModifiers.Shift) != 0 && (cki.Modifiers & ConsoleModifiers.Control) != 0 && cki.Key==ConsoleKey.RightArrow)
            ////    //{
            ////    //    Console.WriteLine("Validacion");
            ////    //}
            ////    //else
            ////    //{
            ////    //    Console.WriteLine("");
            ////    //}

            ////    Console.Write(" --- You pressed ");
            ////    if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            ////    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            ////    if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            ////    Console.WriteLine(cki.Key.ToString());

            //} while (cki.Key != ConsoleKey.Escape);
        }


    }
}
