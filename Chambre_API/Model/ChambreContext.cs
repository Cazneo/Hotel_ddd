using Microsoft.EntityFrameworkCore;

namespace Chambre_API.Model
{
    public class ChambreContext : DbContext
    {
        public ChambreContext(DbContextOptions<ChambreContext> options) : base(options) { }

        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<EquipementChambre> Equipements { get; set; } 
        public DbSet<TypeChambre> Types { get; set; }
    }
}
