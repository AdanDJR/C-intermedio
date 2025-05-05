using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP
{
    interface ITaxCalculatorStrategy
    {
        decimal CalculateTax(decimal taxableIncome);
    }
}
