using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediumEfCoreRelationships.SeedData
{
    public class BookCategorySeedData : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasData
                (
                    new BookCategory { Id=1,  BookId=1, CategoryId=1},
                    new BookCategory { Id=2,  BookId=1, CategoryId=2},
                    new BookCategory { Id=3,  BookId=2, CategoryId=1},
                    new BookCategory { Id=4,  BookId=2, CategoryId=2},
                    new BookCategory { Id=5,  BookId=3, CategoryId=1},
                    new BookCategory { Id=6,  BookId=3, CategoryId=2},
                    new BookCategory { Id=7,  BookId=4, CategoryId=1},
                    new BookCategory { Id=8,  BookId=4, CategoryId=3},
                    new BookCategory { Id=9,  BookId=5, CategoryId=4},
                    new BookCategory { Id=10, BookId=5, CategoryId=5}
                );
        }
    }
}
