namespace CompetitorEntries.Models
{
    using Microsoft.EntityFrameworkCore;

    public class CompetitorEntriesDbContext : DbContext
    {
        public CompetitorEntriesDbContext()
        {
            base.Database.EnsureCreated();
        }

        public DbSet<Competitor> Competitors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CompetitorEntries;Integrated Security=True");
        }
    }
}
