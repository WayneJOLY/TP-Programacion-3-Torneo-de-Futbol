using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTORNEO_FUTBOL
{
    public class CPersona : IComparable
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

        public override string ToString() { 
            string datos = "Nombre: " + this.nom + "\nApellido: " + this.ape +"\nDni: " + this.dni;
            return datos;
        }

        public int CompareTo(object AUX)
        {
            if (AUX is CPersona)
            {
                return (int)(this.ape.CompareTo(((CPersona)AUX).ape));
            }
            return int.MaxValue;
        }
    }
}

