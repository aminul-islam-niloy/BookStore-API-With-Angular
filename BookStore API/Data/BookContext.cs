using BookStore_API.models;
using Microsoft.EntityFrameworkCore;

namespace BookStore_API.Data
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
