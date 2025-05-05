using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP
{
    class Persona
    {
        protected string Nombre;
        protected string Ciudad;
        protected int Edad;
        public Persona(string nombre, string ciudad, int edad)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Edad = edad;
        }
        public virtual void InformacionPersona()
        {
            string Informacion = this.Nombre + " " + this.Ciudad + " " + this.Edad;
            Console.WriteLine(Informacion);

        }
    }
}
