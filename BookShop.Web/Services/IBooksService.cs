using BookShop.Web.Pages;

namespace BookShop.Web.Services
{
    public interface IBooksService
    {
        //ApiCall
        Task<List<BookDto>> GetAll();
        Task<BookDto> GetBook(string guid);
        ////SchopingCart
        //Task AddToCart(ShoppingCart shoppingCart);
        //Task<List<ShoppingCart>> GetAllCart();
        //Task ClearCart();
    }
}