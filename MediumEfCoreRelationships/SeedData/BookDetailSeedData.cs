using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.SeedData
{
    public class BookDetailSeedData : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasData(
                new BookDetail { Id=1,BookId =1,ReleaseYear = 1922,Pages= 409,Country="Türkiye",ISBN= "9785486037986" },
                new BookDetail { Id=2,BookId=2, ReleaseYear= 1937,Pages =222,Country= "Türkiye", ISBN= "9786051215877" },
                new BookDetail { Id =3,BookId=3,ReleaseYear = 1928,Pages=160,Country= "Türkiye", ISBN= "9789751026569" },
                new BookDetail { Id=4, BookId = 4 ,ReleaseYear= 1998,Pages=314,Country="İngiltere",ISBN= "9781408855669" },
                new BookDetail { Id=5,BookId=5,ReleaseYear=2008, Pages=464, Country="Amerika" ,ISBN= "978-0132350884"}
                );
        }
    }
}
