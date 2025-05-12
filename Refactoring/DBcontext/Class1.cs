using System.Collections.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DBcontext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Asiento> Asientos { get; set; }

        // Constructor para recibir las opciones
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Configuración de la base de datos (aunque ahora se puede quitar de aquí si usas el constructor)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=VictorFDJ;Database=C#-Intermedio;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=True");
            }
        }
    }
}
