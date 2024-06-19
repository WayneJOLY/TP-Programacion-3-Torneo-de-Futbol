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
                    aux.SacarJugador(dni);
                    this.ListaEquipos.Remove(aux);
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

            if (jugador != null && equipo != null && !jugador.Esta_en_un_Equipo)
            {
                jugador.Esta_en_un_Equipo=true;
                equipo.AgregarJugador(jugador);
                return true;
            }
            return false;
        }
 
        public bool ElEquipoPuedeParticipar(CEquipo equipo)// Averiguar que el equipo es apto para participar
        {
            if (equipo.GetCantidadDeJugadores>=11 && equipo.GetCantidadDeJugadores <= 23 && equipo.TieneArquero())
            {
                return true;
            }

            return false;
        }
    }
    
}




