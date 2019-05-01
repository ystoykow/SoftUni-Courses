using Microsoft.EntityFrameworkCore;

namespace WildlifeRefuge.Models
{
    public class WildlifeRefugeDbContext : DbContext
    {
        public WildlifeRefugeDbContext()
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=WildlifeRefuge;Integrated Security=True");
        }
    }
}
