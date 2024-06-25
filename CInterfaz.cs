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
            Console.WriteLine("**********************************************************");
            Console.WriteLine("\n[A]     Registrar Jugador"); // LISTO 
            Console.WriteLine("\n[B]     Registrar Entrenador"); // LISTO
            Console.WriteLine("\n[C]     Registrar Equipo"); // LISTO
            Console.WriteLine("\n[D]     Asociar jugador a un equipo."); // LISTO
            Console.WriteLine("\n[E]     Listar Equipos"); // LISTO
            Console.WriteLine("\n[F]     Listar jugadores de un equipo"); // LISTO
            Console.WriteLine("\n[G]     Expulsar jugador"); // LISTO
            Console.WriteLine("\n[H]     Listar todos los participantes del torneo"); // LISTO
            Console.WriteLine("\n[I]     Verificar si los equipos estan aptos para jugar el torneo"); // LISTO
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
