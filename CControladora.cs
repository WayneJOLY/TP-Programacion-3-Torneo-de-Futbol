using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CTORNEO_FUTBOL
{
    public class CControladora
    {
        static void Main()
        {
            char OPCION;
            CTorneo torneo = new CTorneo();
            do
            {


                char.TryParse(CInterfaz.DarOpcion().ToUpper(), out OPCION);
                switch (OPCION)
                {
                    case 'A':
                        string APE = CInterfaz.PedirDato("Ingrese el Apellido: ");
                        string NOM = CInterfaz.PedirDato("Ingrese el Nombre: ");
                        string DNI = CInterfaz.PedirDato("Ingrese el DNI: ");
                        string NAC = CInterfaz.PedirDato("Ingrese la fecha de nacimiento: ");
                        string POS = CInterfaz.PedirDato("Ingrese la posicion: ");
                        if (torneo.BuscarJugador(DNI) == null)
                        {
                            CJugador jugador = new CJugador(APE, NOM, DNI, POS,NAC);
                            torneo.AgregarJugador(jugador);
                        }
                        break;

                    case 'B':

                        Console.WriteLine("Lista de Jugadores de Torneo :{0}", torneo.ListaDeJugadores());

                        break;
                    case 'C':
                        NOM = CInterfaz.PedirDato("Ingrese el Nombre del Equipo: ");
                        string ID = CInterfaz.PedirDato("Ingrese el Codigo Identificador: ");
                        string COL = CInterfaz.PedirDato("Ingrese el o los colores del equipo: ");
                        if (torneo.BuscarEquipo(ID) == null)
                        {
                            CEquipo equipo = new CEquipo(NOM, ID, COL);
                            torneo.AgregarEquipo(equipo);
                        }
                        break;
                    case 'D':
                        Console.WriteLine(torneo.ListarEquipos());
                        break;
                    case 'E':
                        ID = CInterfaz.PedirDato("Ingrese el codigo del equipo: ");
                        DNI = CInterfaz.PedirDato("Ingrese el DNI del jugador: ");
                        if (torneo.AgregarJugadorAEquipo(DNI, ID)) Console.WriteLine("Jugador asociado a Equipo correctamente");
                        else Console.WriteLine("El jugador no se ha podido asociar");
                        break;
                    case 'G':
                        APE = CInterfaz.PedirDato("Ingrese el Apellido: ");
                        NOM = CInterfaz.PedirDato("Ingrese el Nombre: ");
                        DNI = CInterfaz.PedirDato("Ingrese el DNI: ");
                        string TEL = CInterfaz.PedirDato("Ingrese el numero de telefono: ");
                        if (torneo.BuscarEntrenador(DNI) == null)
                        {
                            CEntrenador entrenador = new CEntrenador(APE, NOM, DNI, TEL);
                            torneo.AgregarEntrenador(entrenador);
                        }
                        break;
                }
            } while (OPCION != 'S');





        }
    }
}
