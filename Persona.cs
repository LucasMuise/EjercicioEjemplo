using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {      //CONSTRUCTORES
        public Persona(string nombre) {
       this.nombre = nombre;
        }
        private string nombre;
        private int edad;
        private string nacionalidad;

        //propiedades
        public string Nombre
        {
            get { return nombre; }
        } 
     
        public int Edad
        {
            get { return edad; }
            set { edad = value; }

        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        //Métodos
        
        public string saludar()
        {
            return "Hola soy " + nombre;
        }

        //Sobrecarga de métodos

        public string saludar(string nombre)
        {
            return "hola  " + nombre + ".. soy : " + this.nombre;
        }

    }
}
