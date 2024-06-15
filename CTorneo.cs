﻿using CTORNEO_FUTBOL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoDeFutbol
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
            if (aux == null) 
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
    
    
    
    
    
    
    
    
    
    
    
    
    
    }

    

}