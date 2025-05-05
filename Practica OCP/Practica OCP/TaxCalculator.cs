using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP
{
    class TaxCalculator
    {
        private readonly Dictionary<string, ITaxCalculatorStrategy> strategies;

        public TaxCalculator()
        {
            strategies = new Dictionary<string, ITaxCalculatorStrategy>
        {
            { "India", new IndiaTaxCalculator() },
            { "USA", new USATaxCalculator() },
            { "UK", new UKTaxCalculator() }
        };
        }

        public decimal Calculate(decimal income, decimal deduction, string country)
        {
            decimal taxableIncome = income - deduction;

            if (strategies.ContainsKey(country))
            {
                return strategies[country].CalculateTax(taxableIncome);
            }

            throw new NotSupportedException($"País no soportado: {country}");
        }
    }
    public class IndiaTaxCalculator : ITaxCalculatorStrategy
    {
        public decimal CalculateTax(decimal taxableIncome)
        {
            
            return taxableIncome * 0.15m;
        }
    }

    public class USATaxCalculator : ITaxCalculatorStrategy
    {
        public decimal CalculateTax(decimal taxableIncome)
        {
            
            return taxableIncome * 0.20m;
        }
    }

    public class UKTaxCalculator : ITaxCalculatorStrategy
    {
        public decimal CalculateTax(decimal taxableIncome)
        {
            
            return taxableIncome * 0.18m;
        }
    }

}
