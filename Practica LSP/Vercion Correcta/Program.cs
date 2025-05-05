using System;

abstract class FiguraGeometrica
{
    public abstract int CalcularArea();
}

class Rectangulo : FiguraGeometrica
{
    public int Base { get; set; }
    public int Altura { get; set; }

    public override int CalcularArea()
    {
        return Base * Altura;
    }
}

class Cuadrado : FiguraGeometrica
{
    public int Lado { get; set; }

    public override int CalcularArea()
    {
        return Lado * Lado;
    }
}

class Program
{
    static void Main()
    {
        FiguraGeometrica rect = new Rectangulo { Base = 5, Altura = 3 };
        Console.WriteLine("Área rectángulo: " + rect.CalcularArea());

        FiguraGeometrica cuad = new Cuadrado { Lado = 5 };
        Console.WriteLine("Área cuadrado (correcto): " + cuad.CalcularArea());
    }
}

