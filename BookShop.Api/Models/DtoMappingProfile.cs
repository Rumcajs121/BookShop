using AutoMapper;
using BookShop.Api.Entities;

namespace BookShop.Api.Models
{
    public class DtoMappingProfile:Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<Book, BookDto>();
        }
    }
}
