using DBcontext;
using Microsoft.EntityFrameworkCore;
using Entities;

class Program
{
    static void Main(string[] args)
    {
      
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer("Server=VictorFDJ;Database=C#-Intermedio;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");

        
        using (var context = new ApplicationDbContext(optionsBuilder.Options))
        {
           
            var nuevoAsiento = new Asiento
            {
                BusId = 2,
                NumeroPiso = 2,
                NumeroAsiento = 11,
                FechaCreacion = DateTime.Now
            };

            context.Asientos.Add(nuevoAsiento);
            context.SaveChanges();

            Console.WriteLine("Nuevo asiento agregado con éxito.");
        }
    }
}
