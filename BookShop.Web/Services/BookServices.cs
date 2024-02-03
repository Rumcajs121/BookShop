using BookShop.Web.Pages;
using Newtonsoft.Json;
using System.Diagnostics;
using Blazored.LocalStorage;

namespace BookShop.Web.Services
{
    public class BookServices: IBooksService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public BookServices(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }



        //Api call
        public async Task<List<BookDto>> GetAll()
        {
            var response = await _httpClient.GetAsync("BookShop/GetAll");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var books = JsonConvert.DeserializeObject<List<BookDto>>(content);
            return books;
        }

        public async Task<BookDto> GetBook(string guid)
        {
            
            var response = await _httpClient.GetAsync($"BookShop/GetBook/{guid}");
            var content=await response.Content.ReadAsStringAsync();
            var book=JsonConvert.DeserializeObject<BookDto>(content);
            return book;
        }
        //    //SchopingCart
        //    public async Task AddToCart(ShoppingCart shoppingCart)
        //    {
        //        var cartItems = await GetAllCart();

        //        if (cartItems.Any(x => x.Guid == shoppingCart.Guid))
        //        {
        //            var existingItem = cartItems.First(x => x.Guid == shoppingCart.Guid);
        //            existingItem.Quantity += shoppingCart.Quantity;
        //        }
        //        else
        //        {
        //            cartItems.Add(shoppingCart);
        //        }

        //        await _localStorageService.SetItemAsync("cartItems", cartItems);
        //    }

        //    public async Task<List<ShoppingCart>> GetAllCart()
        //    {
        //        var carItems = await _localStorageService.GetItemAsync<List<ShoppingCart>>("carItems");
        //        return carItems ?? new List<ShoppingCart>();
        //    }

        //    public async Task ClearCart()
        //    {
        //        await _localStorageService.RemoveItemAsync("cartItems");
        //    }
    }
}
