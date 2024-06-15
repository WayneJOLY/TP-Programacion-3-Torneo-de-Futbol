
namespace CTORNEO_FUTBOL
{
    public class CJugador
    {

        //Atributos Variables miembro
        private string ape;
        private string nom;
        private string pos;
        private string dni;
        private DateTime fecha_nac;
      
        
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

        //setters
        public void SetApellido(string apellido)
        { this.ape = apellido; }

        public void SetNombre(string nombre)
        { this.nom = nombre; }

        public void SetPosicion(string posicion)
        { this.pos = posicion; }

        public void SetDni(string d)
        { this.dni = d; }

        public void SetFecha(DateTime fecha)
        { this.fecha_nac = fecha; }

        //getters
        public string GetApellido()
        { return this.ape; }

        public string GetNombre()
        { return this.nom; }

        public string GetPosicion()
        { return this.pos; }

        public string GetDni()
        { return this.dni; }

        public DateTime GetFecha_nac()
        { return this.fecha_nac; }

       
        //Constructor
        public CJugador(string ape , string nom , string pos , string dni , DateTime fecha_nac )
        {
            this.ape = ape;
            this.nom = nom;
            this.pos = pos;
            this.dni = dni;
            this.fecha_nac = fecha_nac;
        }
        


    }



}

// Jugador entre 18 - 45 anios, DNI, Apellidos, Nombres, Fechanac y posicion(arquero, defenson, medicampista, delantero)
