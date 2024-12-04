using Microsoft.EntityFrameworkCore;

namespace ADV_Business_Final_Project
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        // DbSets for your entity classes
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(b => b.BookID);
                entity.Property(b => b.Title).IsRequired().HasMaxLength(100);
                entity.Property(b => b.Author).IsRequired().HasMaxLength(50);
                entity.Property(b => b.Genre).IsRequired().HasMaxLength(30);
            });

            modelBuilder.Entity<Borrower>(entity =>
            {
                entity.HasKey(br => br.BorrowerID);
                entity.Property(br => br.Name).IsRequired().HasMaxLength(50);
                entity.Property(br => br.Email).IsRequired().HasMaxLength(100);
            });
        }
    }
}
