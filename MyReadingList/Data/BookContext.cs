using Microsoft.EntityFrameworkCore;
using MyReadingList.Models;

namespace MyReadingList.Data;

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options) { }
  
    public DbSet<Book> Books { get; set; }
  
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Book>().HasKey(b => b.Id);
        base.OnModelCreating(builder);
    }
}
