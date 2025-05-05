using Practica_OCP;

Console.WriteLine("Ingrese su ingreso total:");
decimal income = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingrese su deducción:");
decimal deduction = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingrese su país (India, USA, UK):");
string country = Console.ReadLine();

var calculator = new TaxCalculator();

try
{
    decimal tax = calculator.Calculate(income, deduction, country);
    Console.WriteLine($"El impuesto calculado es: {tax:C}");
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}