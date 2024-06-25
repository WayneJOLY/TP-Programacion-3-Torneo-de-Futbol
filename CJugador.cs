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
        private Posiciones pos;
        private string dni;
        private DateTime fecha_nac;
        public bool Esta_en_un_Equipo;// Averiguar si el Jugador ya pertenece a un equipo
        //Constructor
        public CJugador(string ape , string nom , Posiciones pos , string dni , DateTime fecha_nac ) : base( ape, nom, dni )
        {
            this.pos = pos;
            this.fecha_nac = fecha_nac;
        }
        
        // Metodos
        public override string ToString()
        {
            string datos = base.ToString();
            datos += "\nPosicion: " + this.pos + "\nFecha nacimiento: " + this.fecha_nac;
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
        public Posiciones GetPosicion() { return this.pos; }
        public DateTime GetFecha_nac() { return this.fecha_nac; }
        public void SetEstaEquipo() { this.Esta_en_un_Equipo = true; }
    }

}

// Jugador entre 18 - 45 anios, DNI, Apellidos, Nombres, Fechanac y posicion(arquero, defenson, medicampista, delantero)
