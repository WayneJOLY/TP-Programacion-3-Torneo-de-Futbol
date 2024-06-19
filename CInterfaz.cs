using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CTORNEO_FUTBOL
{
    public class CInterfaz
    {
        static CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static string DarOpcion()
        {
            Console.Clear();
            Console.WriteLine("**********************************************************");
            Console.WriteLine("*                Sistema de Gestión del Torneo            *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\n[A]     Registrar Jugador.");
            Console.WriteLine("\n[B]     Listar datos de todos los jugadores del torneo.");
            Console.WriteLine("\n[C]     Registrar Equipo");
            Console.WriteLine("\n[D]     Listar datos completos de un equipo.");
            Console.WriteLine("\n[E]     Asignar jugador a un equipo");
            Console.WriteLine("\n[F]     Listar Jugadores de un equipo");
            Console.WriteLine("\n[G]     Registrar Entrenador");
            Console.WriteLine("\n[H]     Asignar Entrenador a Equipo");
            Console.WriteLine("\n[I]     Ver todos los datos de un equipo");
            Console.WriteLine("\n[J]     Eliminar un jugador del torneo");
            Console.WriteLine("\n[S]     Salir de la aplicación.");
            Console.WriteLine("\n********************************************************");
            return CInterfaz.PedirDato("opción elegida");
        }
        public static string PedirDato(string nombDato)
        {
            Console.Write("[?] Ingrese " + nombDato + ": ");
            string ingreso = Console.ReadLine();
            while (ingreso == "")
            {
                Console.Write("[!] " + nombDato + "es de ingreso OBLIGATORIO:");
                ingreso = Console.ReadLine();
            }
            Console.Clear();
            return ingreso.Trim();
        }

        public static void MostrarInfo(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("<Pulse Enter>");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
