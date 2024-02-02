namespace BookShop.Web.Pages
{
    public class BookDto
    {
        public Guid Guid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string? Brand { get; set; }
        public string? Image { get; set; }
        public bool Availability { get; set; }
        public decimal Price { get; set; }
    }
}
