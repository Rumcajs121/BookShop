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

        public async Task<List<ShoppingCart>> GetAllCart()
        {
            List<ShoppingCart> carts= await _localStorageService.GetItemAsync<List<ShoppingCart>>("cart");
            return carts;
        }

        public async Task AddToCart(BookDto book)
        {
            var cart = await GetAllCart();

            if (cart == null)
            {
                cart = new List<ShoppingCart>();
            }

            var cartItem = new ShoppingCart
            {
                BookId = book.Guid,
                Title = book.Title,
                Price = book.Price,
                Image = book.Image,
                Quantity = 1
            };

            cart.Add(cartItem);

            await _localStorageService.SetItemAsync("cart", cart);
            
        }
        public async Task<int> ShopingCartCount()
        {
            var cartItems = await _localStorageService.GetItemAsync<List<ShoppingCart>>("cart");
            return cartItems?.Count ?? 0;
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


    }
}
