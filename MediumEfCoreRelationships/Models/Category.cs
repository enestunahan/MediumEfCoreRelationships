namespace MediumEfCoreRelationships.Models
{
    public class Category
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
