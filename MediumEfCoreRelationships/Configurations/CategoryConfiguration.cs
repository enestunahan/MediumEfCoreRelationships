using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Description).HasMaxLength(100);

            builder.Property(x => x.CreatedDate)
                 .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}
