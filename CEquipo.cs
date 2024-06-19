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
        private ArrayList colores;
        private ArrayList ListaJugadores;
        private CEntrenador entrenador;

        public CEquipo(string nombre, string codigo, ArrayList colores, CEntrenador entrenador)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.colores = new ArrayList();
            this.entrenador = entrenador;
        }

        public string GetCodigo()
        { return this.codigo; }

        public string GetNombre()
        { return this.nombre; }

        public ArrayList GetColores()
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
        
        
    }
}
