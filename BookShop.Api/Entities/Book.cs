namespace BookShop.Api.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public Guid Guid { get; set; } = new Guid();
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Author { get; set; } = default!;
        public string? Brand { get; set; }
        public string? Image { get; set;}
        public bool Availability { get; set; }
        public decimal Price { get; set; } = default!;
    }
}
