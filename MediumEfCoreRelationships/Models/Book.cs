namespace MediumEfCoreRelationships.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public BookDetail BookDetail { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
