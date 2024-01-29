using Bogus;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookShop.Api.Entities
{
    public class BogusDataSeeder
    {
        private readonly BooksDbContext _dbContext;

        public BogusDataSeeder(BooksDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Books.Any())
                {
                    var bookFaker = new Faker<Book>()
                        .RuleFor(b => b.Title, f => f.Commerce.ProductName())
                        .RuleFor(b => b.Description, f => f.Lorem.Paragraph())
                        .RuleFor(b => b.Author, f => f.Name.FullName())
                        .RuleFor(b => b.Brand, f => f.Company.CompanyName())
                        .RuleFor(b => b.Availability, f => f.Random.Bool())
                        .RuleFor(b => b.Price, f => f.Random.Decimal(10, 1000))
                        .RuleFor(b => b.Image, f => f.Image.ToString());
                    var books = bookFaker.Generate(12);
                    _dbContext.Books.AddRange(books);
                    _dbContext.SaveChanges();
                }
            }
            
        }
    }
}
