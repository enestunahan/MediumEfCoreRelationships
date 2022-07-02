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
                 new Book { Id = 1, Name = "Çalıkuşu" },
                 new Book { Id = 2, Name = "Kuyucaklı Yusuf" },
                 new Book { Id = 3, Name = "Acımak" },
                 new Book { Id = 4, Name = "Harry Potter Sırlar Odası" },
                 new Book { Id = 5, Name = "Clean Code" }
                 );
        }
    }
}
