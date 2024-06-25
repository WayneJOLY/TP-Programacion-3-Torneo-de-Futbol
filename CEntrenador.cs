using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTORNEO_FUTBOL
{
    public class CEntrenador : CPersona
    {
        private string apellido, nombre, dni, telefono;

        public CEntrenador(string apellido, string nombre, string dni, string telefono): base (apellido, nombre, dni)
        {
            this.telefono = telefono;
        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        public override string ToString()
        {
            string datos = base.ToString();
            datos += "\nTelefono: " + this.telefono;
            return datos;
        }

    }
}
