using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP
{
    class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double r)
        {
            Radio = r;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
