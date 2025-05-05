class FiguraGeometrica
{
    public int Base { get; set; }
    public int Altura { get; set; }

    public virtual int CalcularArea()
    {
        return Base * Altura;
    }
}

class Rectangulo : FiguraGeometrica
{
    public override int CalcularArea()
    {
        return Base * Altura;
    }
}

class Cuadrado : FiguraGeometrica
{
    // Este método está mal, porque Cuadrado debería forzar que Base == Altura
    public override int CalcularArea()
    {
        return Base * Altura; // Incorrecto si Base != Altura
    }
}

class Program
{
    static void Main()
    {
        FiguraGeometrica figura = new FiguraGeometrica { Base = 5, Altura = 3 };
        Console.WriteLine("Área figura: " + figura.CalcularArea());

        Rectangulo rect = new Rectangulo { Base = 5, Altura = 3 };
        Console.WriteLine("Área rectángulo: " + rect.CalcularArea());

        Cuadrado cuadra = new Cuadrado { Base = 5, Altura = 3 }; // LSP VIOLADO aquí
        Console.WriteLine("Área cuadrado (incorrecto): " + cuadra.CalcularArea());
    }
}
