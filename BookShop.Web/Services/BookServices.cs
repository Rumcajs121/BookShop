using BookShop.Web.Pages;
using Newtonsoft.Json;
using System.Diagnostics;


namespace BookShop.Web.Services
{
    public class BookServices: IBooksService
    {
        private readonly HttpClient _httpClient;

        public BookServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<BookDto>> GetAll()
        {
            var response = await _httpClient.GetAsync("BookShop/GetAll");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var books = JsonConvert.DeserializeObject<List<BookDto>>(content);
            return books;
        }
    }
}
