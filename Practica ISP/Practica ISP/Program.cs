using Practica_ISP;
IAve canario = new Canario();
IAve pato = new Pato();
IAveCazadora aguilaCazadora = new Aguila();
IAveNadadora patoNadador = new Pato(); 

Console.WriteLine("=== Canario ===");
canario.Volar();
canario.Cantar();
canario.PonerHuevos();

Console.WriteLine("\n=== Pato ===");
pato.Volar();
pato.Cantar();
pato.PonerHuevos();
patoNadador.Nadar(); 

Console.WriteLine("\n=== Águila ===");
IAve aguila = (IAve)aguilaCazadora;
aguila.Volar();
aguila.Cantar();
aguila.PonerHuevos();
aguilaCazadora.Cazar(); 

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
