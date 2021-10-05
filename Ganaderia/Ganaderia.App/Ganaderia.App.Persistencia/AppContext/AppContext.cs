using Ganaderia.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Ganaderia.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ganadero> Ganaderos { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }
        public DbSet<Ganado> Ganados { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog=Grupo35-5");
            }
        }
    }
}