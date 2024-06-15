using System;

namespace CTORNEO_FUTBOL
{
    public class CEquipo
    {
        private string id, nombre, colores;
        private CEntrenador Tecnico = new CEntrenador();

        // Constructor
        public CEquipo(string codigo_id, string nombre, string colores, CEntrenador tecnico)
        {
            this.id = codigo_id;
            this.nombre = nombre;
            this.colores = colores;
            Tecnico = tecnico;

        }

        public string GetCodigo()
        { return this.id; }

        public string GetNombre()
        { return this.nombre; }

        public string GetColores()
        { return this.colores; }

        // Clase Entrenador



        // Metodo DarDatos
        public string DarDatos()
        {
            string datos = "Codigo Equipo: " + this.id;
            datos += "-" + this.nombre;
            datos += "-" + this.colores;
            // Falta datos Clase CEntrenador
            return datos;
        }
    }
}