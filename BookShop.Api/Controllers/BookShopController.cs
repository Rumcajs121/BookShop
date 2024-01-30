using BookShop.Api.Entities;
using BookShop.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class BookShopController : ControllerBase
    {
        private readonly IBookShopRepository _repository;

        public BookShopController(IBookShopRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetAll()
        {
            var books=await _repository.GettAll();
            return Ok(books);
        }
    }
}
