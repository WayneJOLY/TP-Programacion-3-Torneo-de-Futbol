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
            ListaJugadores = new ArrayList(23);
        }

        public string GetCodigo()
        { return this.codigo; }

        public string GetNombre()
        { return this.nombre; }

        public string GetColores()
        { return this.colores; }

        public void SetEntrenador(CEntrenador ent) { this.entrenador = ent; }
        // Metodo DarDatos
        public override string ToString()
        {
            string datos = "Codigo Equipo: " + this.codigo;
            datos += " - " + this.nombre;
            datos += " - " + this.colores;
            datos += " \nEntrenador: \n" + this.entrenador.ToString();
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
            if (aux == null && jugador.Esta_en_un_Equipo == false)
            {
                this.ListaJugadores.Add(jugador);
                jugador.SetEstaEquipo();
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
            return this.ListaJugadores.Count;
        }

        public bool TieneArquero()
        {
            foreach (CJugador jugador in ListaJugadores)
            {
                if (jugador.GetPosicion() == Posiciones.Arquero)
                {
                    return true;
                }
            }
            return false;
        }
        public string ListarJugadores()
        {
            string datos = "Lista de jugadores: \n\n";
            this.ListaJugadores.Sort();
            foreach (CJugador jugador in ListaJugadores)
            {
                datos += jugador.ToString();
            }
            return datos;
        }
    }
}


