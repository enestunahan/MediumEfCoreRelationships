namespace MediumEfCoreRelationships.Models
{
    public class BookDetail
    {
        public int Id { get; set; }
        public short ReleaseYear { get; set; }
        public short Pages { get; set; }  
        public string ISBN { get; set; }
        public string Country { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        // Foreign Key
        public int BookId { get; set; }

        // Navigation Property
        public Book Book { get; set; }  
    }
}
