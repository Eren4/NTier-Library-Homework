using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Project.BLL.DTOs;
using Project.Entities.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project.BLL.MappingProfiles
{
    public class DTOMappingProfile : Profile
    {
        public DTOMappingProfile()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<Tag, TagDTO>().ReverseMap();
            CreateMap<BookTag, BookTagDTO>().ReverseMap();
        }
    }
}
