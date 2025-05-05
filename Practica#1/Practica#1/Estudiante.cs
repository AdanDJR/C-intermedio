using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP
{
    class Estudiante : Persona
    {
        private string Carrera;
        private string Matricula;
        public Estudiante(string nombre,string ciudad,int edad, string carrera,string matricula)
        : base(nombre,ciudad,edad)
        {
            this.Carrera = carrera;
            this.Matricula = matricula;
        }
        public override void InformacionPersona()
        {
            string Informacion = this.Nombre + " " + this.Ciudad + " " + this.Edad + " " + this.Carrera + " " + this.Matricula;
            Console.WriteLine(Informacion);
        }

    }
}
