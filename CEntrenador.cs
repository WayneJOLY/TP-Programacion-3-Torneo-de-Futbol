using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTORNEO_FUTBOL
{
    public class CEntrenador
    {
        private string apellido, nombre, dni, telefono;;

        public CEntrenador(string apellido, string nombre, string dni, string telefono)
        {
            this.dni = dni;
            this.telefono = telefono;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public uint GetDni()
        {
            return this.dni;
        }
        public uint GetTelefono()
        {
            return this.telefono;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public string GetNombre()
        {
            return this.nombre;
        }

        public string DarDatos()
        {
            string datos = "Jugador de DNI: " + this.dni.ToString();
            datos = datos + "-" + this.telefono.ToString() + "-" + this.apellido + "-" + this.nombre;
            return datos;
        }

    }
}
