namespace MediumEfCoreRelationships.Models
{
    public class BookCategory : BaseEntity<int>
    {
        public short CategoryId { get; set; }
        public Category Category { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
