namespace BookShop.Web.Pages
{
    public class ShoppingCart: IEquatable<ShoppingCart>
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
        public bool Equals(ShoppingCart other)
        {
            if (other is null)
                return false;

            return BookId == other.BookId && Title == other.Title;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BookId, Title);
        }
    }

}
