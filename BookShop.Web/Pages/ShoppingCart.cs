namespace BookShop.Web.Pages
{
    public class ShoppingCart
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
