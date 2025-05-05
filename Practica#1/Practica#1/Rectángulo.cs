using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP
{
    class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
