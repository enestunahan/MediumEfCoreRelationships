using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.Configurations
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x=>x.IsDeleted)
                .HasDefaultValue(false);

            builder.HasOne(x=>x.Book)
                .WithMany(x=>x.BookCategories)
                .HasForeignKey(x=>x.BookId);

            builder.HasOne(x=>x.Category)
                .WithMany(x=>x.BookCategories)
                .HasForeignKey(x=>x.CategoryId);
        }
    }
}
