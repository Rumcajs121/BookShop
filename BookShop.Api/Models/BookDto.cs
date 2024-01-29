namespace BookShop.Api.Models
{
    public class BookDto
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Author { get; set; } = default!;
        public string? Brand { get; set; }
        public string? Image { get; set; }
        public bool Availability { get; set; }
        public decimal Price { get; set; } = default!;
    }
}
