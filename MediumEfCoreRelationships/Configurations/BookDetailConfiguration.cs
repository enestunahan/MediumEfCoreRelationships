using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.Configurations
{
    public class BookDetailConfiguration : CustomConfiguration<BookDetail,int>
    {       
        public override void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ISBN)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasOne(x => x.Book)
                .WithOne(x => x.BookDetail)
                .HasForeignKey<BookDetail>(x=>x.BookId);
        }
    }
}
