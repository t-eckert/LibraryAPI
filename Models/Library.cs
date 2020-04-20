namespace LibraryAPI.Models
{
    using System.Collections.Generic;

    public class Library
    {
        public int LibraryId { get; set; }
        public string Name { get; set; }
        public List<Media> Media { get; set; }
        public string City { get; set; }
        public List<Library> NearestLibraries { get; set; }
    }
}