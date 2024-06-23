using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTORNEO_FUTBOL
{
    public class CPersona
    {
        // Atributos Variables miembro
        private string ape;
        private string nom;
        private string dni;
        // Constructor
        public CPersona(string ape, string nom, string dni)
        {
            this.ape = ape;
            this.nom = nom;
            this.dni = dni;
        }

        public string GetDni() { return this.dni; }
        public string GetApellido() { return this.ape; }
        public string GetNombre() { return this.nom; }
    }
}

