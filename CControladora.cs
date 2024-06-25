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
                        string APE = CInterfaz.PedirDato("el Apellido ");
                        string NOM = CInterfaz.PedirDato("el Nombre ");
                        string DNI = CInterfaz.PedirDato("el DNI ");
                        DateTime NAC = Convert.ToDateTime(CInterfaz.PedirDato("la fecha de nacimiento "));
                        Posiciones POS;
                        char ELEGIR;
                        do
                        {
                            ELEGIR = CInterfaz.PedirDato("la posición [A] Arquero, [B] Defensa, [C] Mediocampista, [D] Delantero)").ToUpper()[0];

                            switch (ELEGIR)
                            {
                                case 'A':
                                    POS = Posiciones.Arquero;
                                    break;
                                case 'B':
                                    POS = Posiciones.Defensa;
                                    break;
                                case 'C':
                                    POS = Posiciones.Mediocampista;
                                    break;
                                case 'D':
                                    POS = Posiciones.Delantero;
                                    break;
                                default:
                                    CInterfaz.MostrarInfo("Posición no válida. Ingrese una posición válida.");
                                    continue; // Vuelve al inicio del bucle
                            }
                            break; // Sale del bucle si la opción es válida
                        } while (true);
                        if (torneo.BuscarJugador(DNI) == null)
                        {
                            CJugador jugador = new CJugador(APE, NOM, POS, DNI, NAC);
                            torneo.AgregarJugador(jugador);
                            CInterfaz.MostrarInfo("SE REGISTRO CORRECTAMENTE EL JUGADOR");
                        }
                        else CInterfaz.MostrarInfo("NO SE PUDO REGISTRAR AL JUGADOR");
                        break;

                    case 'B':
                        APE = CInterfaz.PedirDato("el Apellido ");
                        NOM = CInterfaz.PedirDato("el Nombre ");
                        DNI = CInterfaz.PedirDato("el DNI ");
                        string TEL = CInterfaz.PedirDato("Ingrese el numero de telefono: ");
                        if (torneo.BuscarEntrenador(DNI) == null)
                        {
                            CEntrenador entrenador = new CEntrenador(APE, NOM, DNI, TEL);
                            torneo.AgregarEntrenador(entrenador);
                            CInterfaz.MostrarInfo("SE REGISTRO CORRECTAMENTE EL ENTRENADOR");
                        }
                        else CInterfaz.MostrarInfo("NO SE PUDO REGISTRAR EL ENTRENADOR");
                        break;
                    case 'C':

                        if(torneo.GetCantidadDeEntrenadores() > 0)
                        {
                            NOM = CInterfaz.PedirDato("el Nombre del Equipo ");
                            string Id = CInterfaz.PedirDato("el Codigo Identificador ");
                            string COL = CInterfaz.PedirDato("el o los colores del equipo ");
                            DNI = CInterfaz.PedirDato("el DNI del entrenador");
                            CEntrenador ENTRENADOR = torneo.BuscarEntrenador(DNI);
                            while(ENTRENADOR == null)
                            {
                                CInterfaz.MostrarInfo("NO EXISTE EL ENTRENADOR");
                                DNI = CInterfaz.PedirDato("el DNI del entrenador correctamente");
                                ENTRENADOR = torneo.BuscarEntrenador(DNI);
                            }
                            if (torneo.BuscarEquipo(Id) == null)
                            {
                                CEquipo equipo = new CEquipo(NOM, Id, COL);
                                equipo.SetEntrenador(ENTRENADOR);
                                torneo.AgregarEquipo(equipo);
                                CInterfaz.MostrarInfo("SE REGISTRO CORRECTAMENTE EL EQUIPO");
                            }
                            else CInterfaz.MostrarInfo("NO SE PUDO REGISTRAR EL EQUIPO");
                        }
                        else
                        {
                            CInterfaz.MostrarInfo("NO HAY ENTRENADORES EXISTENTES");
                        }
                        break;
                    case 'D':
                        DNI = CInterfaz.PedirDato("el DNI ");
                        string ID = CInterfaz.PedirDato("el Codigo Identificador ");
                        if (torneo.AgregarJugadorAEquipo(DNI, ID))
                        {
                            CInterfaz.MostrarInfo("SE AGREGO EL JUGADOR CORRECTAMENTE");
                        }
                        else CInterfaz.MostrarInfo("NO SE PUDO AGREGAR AL JUGADOR");
                        break;
                    case 'E':
                        CInterfaz.MostrarInfo(torneo.ListarEquipos());
                        break;
                    case 'F':
                        ID = CInterfaz.PedirDato("el Codigo Identificador ");
                        torneo.OrdenarJugadores();
                        CInterfaz.MostrarInfo(torneo.BuscarEquipo(ID).ListarJugadores());
                        break;
                    case 'G':
                        DNI = CInterfaz.PedirDato("el DNI ");
                        if (torneo.RemoverJugador(DNI))
                        {
                            CInterfaz.MostrarInfo("SE ELIMINO EL JUGADOR CORRECTAMENTE");
                        }
                        else CInterfaz.MostrarInfo("NO SE ELIMINO EL JUGADOR");
                        break;
                    case 'H':
                        CInterfaz.MostrarInfo(torneo.ListaDeJugadores());
                        CInterfaz.MostrarInfo(torneo.ListaDeEntrenadores());
                        break;
                    case 'I':
                        CInterfaz.MostrarInfo(torneo.ListarEquiposAptos());
                        break;
                }
            } while (OPCION != 'S');
        }
    }
}
