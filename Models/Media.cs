namespace LibraryAPI.Models
{
    using LibraryAPI.Models.Enums;

    public class Media
    {
        public int MediaId { get; set; }
        public MediaType Type { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
    }
}