namespace MediumEfCoreRelationships.Models
{
    public class Category : BaseEntity<short>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
