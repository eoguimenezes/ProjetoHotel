using System.Data.Entity;

namespace ProjetoHotel.Models
{
    public class QuartoDbContext : DbContext
    {
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Quarto> Quarto { get; set; }
    }
}