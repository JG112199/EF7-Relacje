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
            // Konfiguracja One-To-One we fluentAPI od strony rodzica
            /*modelBuilder.Entity<Book>()
                .HasOne(e => e.Isbn)
                .WithOne(e => e.Book)
                .HasForeignKey<Isbn>(e => e.BookId)
                .IsRequired(); */

            // Konfiguracja One-To-Many we fluentAPI od strony rodzica
            modelBuilder.Entity<Publisher>()
                .HasMany(e => e.Books)
                .WithOne(e => e.Publisher)
                .HasForeignKey(e => e.PublisherId)
                .IsRequired();

            // Każdy ISBN jest unikalny 
            modelBuilder.Entity<Isbn>()
                .HasIndex(i => i.IsbnCode)
                .IsUnique();
        }
    }
}
