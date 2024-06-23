using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTORNEO_FUTBOL
{
    public class CJugador : CPersona
    {

        //Atributos Variables miembro
        private string ape;
        private string nom;
        private string pos;
        private string dni;
        private DateTime fecha_nac;
        public bool Esta_en_un_Equipo;// Averiguar si el Jugador ya pertenece a un equipo
        //Constructor
        public CJugador(string ape , string nom , string pos , string dni , DateTime fecha_nac ) : base( ape, nom, dni )
        {
            this.ape = ape;
            this.nom = nom;
            this.pos = pos;
            this.dni = dni;
            this.fecha_nac = fecha_nac;
        }
        
        // Metodos
        public string DarDatos()
        {
            string datos = $"\nApellido: {this.ape}\nNombre: {this.nom}\nPosicion: {this.pos} \nDNI: {this.dni}\nFecha de nacimiento: {this.fecha_nac.ToShortDateString()}\n";
            return datos;
        }

        public bool CalcularEdad()
        {
            int edad = DateTime.Now.Year - fecha_nac.Year;
            if (DateTime.Now < fecha_nac.AddYears(edad))
            {
                edad--;
            }

            if(edad >= 18 && edad <= 45 )
                return true;
            else return false;
        }

        //getters
        /* public string GetApellido() { return this.ape; }

         public string GetNombre() { return this.nom; }



         public override string GetDni() { return this.dni; }*/

        public string GetPosicion() { return this.pos; }
        public DateTime GetFecha_nac() { return this.fecha_nac; }
       
    }

}

// Jugador entre 18 - 45 anios, DNI, Apellidos, Nombres, Fechanac y posicion(arquero, defenson, medicampista, delantero)
