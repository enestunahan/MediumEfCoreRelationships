using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.Configurations
{
    public class BookDetailConfiguration : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ISBN)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(x=>x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("GETDATE()");

            builder.HasOne(x=>x.Book)
                .WithOne(x => x.BookDetail)
                .HasForeignKey<BookDetail>(x=>x.BookId);

        }

    }
}
