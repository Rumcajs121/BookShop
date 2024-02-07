using BookShop.Web.Pages;

namespace BookShop.Web.Services
{
    public interface IBooksService
    {
        //ApiCall
        Task<List<BookDto>> GetAll();
        Task<BookDto> GetBook(string guid);
        Task<int> ShopingCartCount();
        Task AddToCart(BookDto book);
        Task<List<ShoppingCart>> GetAllCart();
        Task<List<ShoppingCart>> DeleteItem(ShoppingCart item);
        Task<List<ShoppingCart>> ChangeInputQuantityToCart(ShoppingCart item);
        Task<List<NbpRate>> GetExchangeRates(); 
    }
}