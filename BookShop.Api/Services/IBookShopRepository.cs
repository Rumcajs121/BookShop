using BookShop.Api.Entities;
using BookShop.Api.Models;

namespace BookShop.Api.Services
{
    public interface IBookShopRepository
    {
        Task <List<BookDto>> GettAll();
    }
}
