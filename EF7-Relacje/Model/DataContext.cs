using Microsoft.EntityFrameworkCore;

namespace EF7_Relacje.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Isbn> Isbns { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Isbn)
                .WithOne(e => e.Book)
                .HasForeignKey<Isbn>(e => e.BookId)
                .IsRequired();
        }
    }
}
