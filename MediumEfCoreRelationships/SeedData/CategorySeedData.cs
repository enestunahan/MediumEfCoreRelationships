using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.SeedData
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
                (
                    new Category { Id=1, Name="Roman"},
                    new Category { Id=2, Name="Edebiyat"},
                    new Category { Id=3, Name="Fantastik"},
                    new Category { Id=4, Name="Akademik"},
                    new Category { Id=5, Name="Yazılım"}
                );
        }
    }
}
