using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.Configurations
{
    public class CategoryConfiguration : CustomConfiguration<Category,short>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(100);
        }
    }
}
