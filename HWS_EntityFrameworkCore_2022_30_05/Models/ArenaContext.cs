using Microsoft.EntityFrameworkCore;

namespace HWS_EntityFrameworkCore_2022_30_05
{
    public class ArenaContext : DbContext
    {
        public DbSet<Gladiator>? Gladiators { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-T74S10A;" +
                                        "Database=ArenaDB2;" +
                                        "Trusted_Connection=True;");
        }
    }
}
