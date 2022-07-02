using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.SeedData
{
    public class BookSeedData : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                 new Book { Id = 1, Name = "Çalıkuşu" ,AuthorId=3},
                 new Book { Id = 2, Name = "Kuyucaklı Yusuf" , AuthorId = 1 },
                 new Book { Id = 3, Name = "Acımak" ,AuthorId=1 },
                 new Book { Id = 4, Name = "Harry Potter Sırlar Odası" , AuthorId = 2 },
                 new Book { Id = 5, Name = "Clean Code" , AuthorId = 4}
                 );
        }
    }
}
