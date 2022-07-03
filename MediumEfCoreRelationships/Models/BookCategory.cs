namespace MediumEfCoreRelationships.Models
{
    public class BookCategory
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public short CategoryId { get; set; }
        public Category Category { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
