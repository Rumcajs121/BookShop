namespace BookShop.Api.Entities
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Author { get; set; } = default!;
        public string? Brand { get; set; }
        public string? Image { get; set;}
        public bool Availability { get; set; }
    }
}
