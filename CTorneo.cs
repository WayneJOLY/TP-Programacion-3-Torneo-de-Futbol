using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTORNEO_FUTBOL
{
    public class CTorneo
    {
        private ArrayList ListaJugadores;
        private ArrayList ListaEquipos;
        private ArrayList ListaEntrenadores;
    
    public CTorneo()
        {
            ListaJugadores = new ArrayList();
            ListaEquipos = new ArrayList();
            ListaEntrenadores = new ArrayList();
        }
        
        public CJugador BuscarJugador (string dni)
        {
            foreach (CJugador jug in ListaJugadores)
            {
                if (jug.GetDni() == dni)
                    return jug;
            }
            return null;
        }
        public bool AgregarJugador (CJugador jugador)
        {
            CJugador aux = BuscarJugador(jugador.GetDni());
            if (aux == null) 
            {
                ListaJugadores.Add(jugador);
                return true;
            }
            else return false;
        }

        public bool RemoverJugador(string dni)
        {
            foreach (CEquipo aux in this.ListaEquipos)
            {
                if (aux.BuscarJugador(dni) != null)
                {
                    this.ListaJugadores.Remove(aux.BuscarJugador(dni));
                    aux.SacarJugador(dni);
                    return true;
                }
            }
            return false;
        }

        public CEquipo BuscarEquipo (string id)
        {
            foreach (CEquipo equipo in ListaEquipos)
            {
                if (equipo.GetCodigo() == id) return equipo;
            }
            return null;
        }

        public bool AgregarEquipo (CEquipo equipo)
        {
            CEquipo aux = BuscarEquipo(equipo.GetCodigo());
            if (aux == null ) 
            { 
                ListaEquipos.Add(equipo);
                return true;
            }
            else return false;
        }

        public CEntrenador BuscarEntrenador (string dni) 
        { 
            foreach (CEntrenador entrenador in ListaEntrenadores) 
            { 
                if (entrenador.GetDni() == dni) return entrenador;
            
            }
            return null;        
        }

        public bool AgregarEntrenador (CEntrenador entrenador)
        {
            CEntrenador aux = BuscarEntrenador(entrenador.GetDni());
            if (aux == null) 
            { 
                ListaEntrenadores.Add(entrenador);
                return true;
            }
            else  return false; 
        }

        public bool AgregarJugadorAEquipo(string dniJugador, string codigoEquipo)
        {

            CJugador jugador = BuscarJugador(dniJugador);
            CEquipo equipo = BuscarEquipo(codigoEquipo);

            if (jugador != null && equipo != null && !jugador.Esta_en_un_Equipo && jugador.CalcularEdad())
            {
                equipo.AgregarJugador(jugador);
                return true;
            }
            return false;
        }
 
        public bool ElEquipoPuedeParticipar(CEquipo equipo)// Averiguar que el equipo es apto para participar
        {
            if ((equipo.GetCantidadDeJugadores() >= 11) && (equipo.GetCantidadDeJugadores() <= 23) && (equipo.TieneArquero()))
            {
                return true;
            }
            return false;
        }
        public string ListarEquipos() // REGRESA LA LISTA DE EQUIPOS DE TORNEO
        {
            string datos = "Equipos: \n\n";
            foreach (CEquipo equipo in ListaEquipos)
            {
                datos += equipo.ToString();
            }
            return datos;
        }
        public string ListarEquiposAptos() // REGRESA LA LISTA DE EQUIPOS DE TORNEO
        {
            string datos = "Equipos aptos: \n\n";
            foreach (CEquipo equipo in ListaEquipos)
            {
                if (ElEquipoPuedeParticipar(equipo))
                {
                    datos += equipo.ToString();
                }
                else {
                    datos += "El equipo: " + equipo.GetNombre() + " no esta apto para participar el torneo\n";
                }
            }
            return datos;
        }

        public string ListaDeJugadores()// REGRESA LA LISTA DE LOS JUGADORES DE TORNEO
        {
            string datos = "JUGADORES: \n\n";

            foreach(CJugador jugador in ListaJugadores)
            {
                datos += jugador.ToString();
                foreach (CEquipo equipo in ListaEquipos)
                {
                    if(BuscarJugador(jugador.GetDni()) != null)
                    {
                        datos += "\nEquipo: " + equipo.GetNombre();
                    }
                }
            }

            return datos;
        }
        public string ListaDeEntrenadores()
        {
            string datos = "ENTRENADORES \n\n";

            foreach (CEntrenador entrenador in ListaEntrenadores)
            {
                datos += entrenador.ToString();
                foreach (CEquipo equipo in ListaEquipos)
                {
                    if (BuscarEntrenador(entrenador.GetDni()) != null)
                    {
                        datos += "\nEquipo: " + equipo.GetNombre();
                    }
                }
            }

            return datos;
        }
        public int GetCantidadDeEntrenadores()// Regresar la cantida de Jugadores del equipo
        {
            return this.ListaEntrenadores.Count;
        }
        public void OrdenarJugadores()
        {
            this.ListaJugadores.Sort();
        }
    }
    
}




