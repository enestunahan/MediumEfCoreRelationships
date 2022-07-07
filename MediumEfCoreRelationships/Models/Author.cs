namespace MediumEfCoreRelationships.Models
{
    public class Author : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // ignore edilecek , dbye yansımasını istemiyorum
        public string FullName =>
            string.Concat(FirstName, " ", LastName);
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public List<Book> Books { get; set; }
    }
}
