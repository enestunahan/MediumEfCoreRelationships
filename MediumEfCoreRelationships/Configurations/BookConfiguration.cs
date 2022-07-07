using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.Configurations
{
    public class BookConfiguration : CustomConfiguration<Book,int>
    {      
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(70);

        }
    }
}
