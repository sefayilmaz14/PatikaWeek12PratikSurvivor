using Microsoft.EntityFrameworkCore;
using PatikaWeek12PratikSurvivor.Entites;

namespace PatikaWeek12PratikSurvivor.Context
{
    public class PatikaSurvivorDbContext : DbContext
    {
        public PatikaSurvivorDbContext(DbContextOptions<PatikaSurvivorDbContext> options) : base(options) { }


        public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();
        public DbSet<CompetitorEntity> Competitors => Set<CompetitorEntity>();
    }
}
