using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.SeedData
{
    public class AuthorSeedData : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
                (
                new Author { Id = 1, FirstName = "Sabahattin", LastName="Ali",     DateOfBirth = new DateTime(1907,02,25), DateOfDeath = new DateTime(1948,04,02)},
                new Author { Id = 2, FirstName = "Joanne" ,  LastName= "Rowling",DateOfBirth = new DateTime(1965,07,31)},
                new Author { Id = 3, FirstName = "Reşat Nuri",LastName="Güntekin",DateOfBirth = new DateTime(1889,11,25), DateOfDeath = new DateTime(1956,12,07)},
                new Author { Id=4,  FirstName = "Robert Cecil", LastName="Martin",DateOfBirth = new DateTime(1952,11,05)}
                );
        }
    }
}
