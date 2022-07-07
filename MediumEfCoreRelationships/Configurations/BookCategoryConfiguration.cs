using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.Configurations
{
    public class BookCategoryConfiguration : CustomConfiguration<BookCategory,int>
    {
        public override void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Book)
                .WithMany(x => x.BookCategories)
                .HasForeignKey(x => x.BookId);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.BookCategories)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
