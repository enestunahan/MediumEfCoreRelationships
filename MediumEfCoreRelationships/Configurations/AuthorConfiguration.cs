using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.Configurations
{
    public class AuthorConfiguration : CustomConfiguration<Author,int>
    {      
        public override void Configure(EntityTypeBuilder<Author> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.FullName);

            builder.Property(x => x.FirstName)
                            .IsRequired()
                            .HasMaxLength(50);

               builder.Property(x => x.DateOfBirth)
                 .IsRequired();

            builder.HasMany(x => x.Books)
                 .WithOne(x => x.Author)
                 .HasForeignKey(x => x.AuthorId);
        }
    }
}
