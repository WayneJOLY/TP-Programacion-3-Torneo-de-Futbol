using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CTORNEO_FUTBOL
{
    public class CEquipo
    {
        private string nombre;
        private string codigo;
        private string colores;
        private ArrayList ListaJugadores;
        private CEntrenador entrenador;

        public CEquipo(string nombre, string codigo, string colores)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.colores = colores;
            ListaJugadores = new ArrayList();
        }

        public string GetCodigo()
        { return this.codigo; }

        public string GetNombre()
        { return this.nombre; }

        public string GetColores()
        { return this.colores; }

        // Metodo DarDatos
        public string DarDatos()
        {
            string datos = "Codigo Equipo: " + this.codigo;
            datos += "-" + this.nombre;
            datos += "-" + this.colores;
            datos += "-" + this.entrenador;
            // Falta datos Clase CEntrenador
            return datos;
        }


        public CJugador BuscarJugador(string dni)
        {
            foreach (CJugador jug in ListaJugadores)
            {
                if (jug.GetDni() == dni)
                    return jug;
            }
            return null;
        }

        public bool AgregarJugador(CJugador jugador)
        {
            CJugador aux = this.BuscarJugador(jugador.GetDni());
            if (aux == null)
            {
                this.ListaJugadores.Add(jugador);
                return true;
            }
            return false;
        }

        public bool SacarJugador(string dni)
        {
            if (this.BuscarJugador(dni) != null)
            {
                foreach (CJugador aux in this.ListaJugadores)
                {
                    if (aux.GetDni() == dni)
                    {
                        this.ListaJugadores.Remove(aux);
                        return true;
                    }
                }
            }
            return false;
        }


        public int GetCantidadDeJugadores()// Regresar la cantida de Jugadores del equipo
        {
            return ListaJugadores.Count;
        }

        public bool TieneArquero()
        {
            foreach (CJugador jugador in ListaJugadores)
            {
                if (jugador.GetPosicion() == "Arquero")
                {
                    return true;
                }
            }
            return false;
        }

    }
}


