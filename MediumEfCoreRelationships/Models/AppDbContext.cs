using MediumEfCoreRelationships.Configurations;
using MediumEfCoreRelationships.SeedData;
using Microsoft.EntityFrameworkCore;

namespace MediumEfCoreRelationships.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookSeedData());
        }
    }
}
