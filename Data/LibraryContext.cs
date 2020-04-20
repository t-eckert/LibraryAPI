namespace LibraryAPI.Data
{
    using LibraryAPI.Models;
    using Microsoft.EntityFrameworkCore;

    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Library> Libraries { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Patron> Patrons { get; set; }

    }
}