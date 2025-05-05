using Practica_OOP;

var persona = new Persona("Adan","Santo Domingo Este",22);
persona.InformacionPersona();
Console.WriteLine(" ");

var estudiante = new Estudiante("Kivi","La caleta",25,"Software","2024-1590");
estudiante.InformacionPersona();
Console.WriteLine(" ");

var rectangulo = new Rectangulo(5, 10);
var circulo = new Circulo(7);
var triangulo = new Triangulo(4, 8);


Console.WriteLine($"Área del Rectángulo: {rectangulo.CalcularArea()}");
Console.WriteLine($"Área del Círculo: {circulo.CalcularArea()}");
Console.WriteLine($"Área del Triángulo: {triangulo.CalcularArea()}");

Console.ReadLine();
