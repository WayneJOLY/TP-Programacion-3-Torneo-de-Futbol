using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTORNEO_FUTBOL
{
    internal class CEquipo
    {
        private string nombre;
        private string codigo;
        private List<string> colores;
        private LinkedList<CJugador> jugadores;
        private CEntrenador entrenador;

        public CEquipo(string nombre, string codigo, LinkedList<string> colores)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.colores = new List<string>(colores);
        }
    }
}
