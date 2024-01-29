using AutoMapper;
using BookShop.Api.Entities;
using BookShop.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Api.Services
{
    public class BookShopRepository:IBookShopRepository
    {
        private readonly BooksDbContext _dbContext;
        private readonly IMapper _mapper;

        public BookShopRepository(BooksDbContext dbContext,IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<BookDto>> GettAll()
        {
            var books = await _dbContext.Books.ToListAsync();
            var booksDto = _mapper.Map<List<Book>, List<BookDto>>(books);
            return booksDto;
        }
    }
}
