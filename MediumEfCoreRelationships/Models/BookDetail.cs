namespace MediumEfCoreRelationships.Models
{
    public class BookDetail : BaseEntity<int>
    {
        public short ReleaseYear { get; set; }
        public short Pages { get; set; }  
        public string ISBN { get; set; }
        public string Country { get; set; }

        // Foreign Key
        public int BookId { get; set; }

        // Navigation Property
        public Book Book { get; set; }  
    }
}
