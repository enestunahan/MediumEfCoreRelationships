namespace MediumEfCoreRelationships.Models
{
    public class Book : BaseEntity<int>
    {
        public string Name { get; set; }
        public BookDetail BookDetail { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
