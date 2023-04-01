using Microsoft.EntityFrameworkCore;

namespace PracticaMVC.Models
{
    public class equiposDbContext : DbContext
    {

        public equiposDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<marcas> marcas { get; set; }
        public DbSet<Estados_equipo> estados_equipo { get; set; }
        public DbSet<Estados_reserva> estados_Reservas { get; set; }
        public DbSet<Facultades> facultades { get; set;}
        public DbSet<Tipo_equipo> tipo_Equipos { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Carreras> carreras { get; set; }
    }
}
