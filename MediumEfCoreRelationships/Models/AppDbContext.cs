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
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookSeedData());
            modelBuilder.ApplyConfiguration(new BookDetailConfiguration());
            modelBuilder.ApplyConfiguration(new BookDetailSeedData());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorSeedData());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategorySeedData());
            modelBuilder.ApplyConfiguration(new BookCategorySeedData());
            modelBuilder.ApplyConfiguration(new BookCategoryConfiguration());
        }
    }
}
