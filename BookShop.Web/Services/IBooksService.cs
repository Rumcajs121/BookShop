using BookShop.Web.Pages;

namespace BookShop.Web.Services
{
    public interface IBooksService
    {
        Task<List<BookDto>> GetAll();
    }
}