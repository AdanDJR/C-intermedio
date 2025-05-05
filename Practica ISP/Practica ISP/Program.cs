using Practica_ISP;

class Canario : IAve
{
    public void Volar() => Console.WriteLine("El canario vuela.");
    public void Cantar() => Console.WriteLine("El canario canta.");
    public void PonerHuevos() => Console.WriteLine("El canario pone huevos.");
}

class Pato : IAve, IAveNadadora
{
    public void Volar() => Console.WriteLine("El pato vuela.");
    public void Cantar() => Console.WriteLine("El pato grazna.");
    public void PonerHuevos() => Console.WriteLine("El pato pone huevos.");
    public void Nadar() => Console.WriteLine("El pato nada.");
}

class Aguila : IAve, IAveCazadora
{
    public void Volar() => Console.WriteLine("El águila vuela.");
    public void Cantar() => Console.WriteLine("El águila grita.");
    public void PonerHuevos() => Console.WriteLine("El águila pone huevos.");
    public void Cazar() => Console.WriteLine("El águila caza.");
}

