﻿using AutoMapper;
using BookShop.Api.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookShop.Api.Models
{
    public class DtoMappingProfile:Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(x=>x.Guid,
                opt=>opt.MapFrom(src=>src.Guid.ToString()));
        }
    }
}
