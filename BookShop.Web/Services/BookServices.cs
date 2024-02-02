using BookShop.Web.Pages;
using Newtonsoft.Json;
using System.Diagnostics;


namespace BookShop.Web.Services
{
    public class BookServices: IBooksService
    {
        private readonly HttpClient _httpClient;

        public BookServices(HttpClient httpClient, LocalStorage)
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

        public async Task<BookDto> GetBook(string guid)
        {
            
            var response = await _httpClient.GetAsync($"BookShop/GetBook/{guid}");
            var content=await response.Content.ReadAsStringAsync();
            var book=JsonConvert.DeserializeObject<BookDto>(content);
            return book;
        }

    }
}
