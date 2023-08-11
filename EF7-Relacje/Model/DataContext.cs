using Microsoft.EntityFrameworkCore;

namespace EF7_Relacje.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Isbn> Isbns { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
