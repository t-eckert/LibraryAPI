namespace LibraryAPI.Models
{
    public class Patron
    {
        public int PatronId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return $"{FirstName} {LastName}"; } }
        public Library LocalLibrary { get; set; }
    }
}