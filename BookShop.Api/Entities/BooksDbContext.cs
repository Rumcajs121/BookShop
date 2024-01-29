using Microsoft.EntityFrameworkCore;

namespace BookShop.Api.Entities
{
    public class BooksDbContext:DbContext
    {
        public DbSet<Book> Books {  get; set; }
        public BooksDbContext(DbContextOptions<BooksDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(x => x.Author)
                .IsRequired();
            modelBuilder.Entity<Book>()
                .Property(x => x.Title)
                .IsRequired();
            modelBuilder.Entity<Book>()
                .Property(x => x.Description)
                .IsRequired();
            modelBuilder.Entity<Book>()
                .Property(x => x.Price)
                .IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}
