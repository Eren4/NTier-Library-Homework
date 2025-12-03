using AutoMapper;
using Project.BLL.DTOs;
using Project.WebApi.Models.RequestModels.Authors;
using Project.WebApi.Models.RequestModels.Books;
using Project.WebApi.Models.RequestModels.BookTags;
using Project.WebApi.Models.RequestModels.Categories;
using Project.WebApi.Models.RequestModels.Tags;

namespace Project.WebApi.MappingProfiles
{
    public class VmMappingProfile : Profile
    {
        public VmMappingProfile()
        {
            CreateMap<CreateCategoryRequestModel, CategoryDTO>();
            CreateMap<UpdateCategoryRequestModel, CategoryDTO>();
            CreateMap<CategoryDTO, CategoryResponseModel>();

            CreateMap<CreateAuthorRequestModel, AuthorDTO>();
            CreateMap<UpdateAuthorRequestModel, AuthorDTO>();
            CreateMap<AuthorDTO, AuthorResponseModel>();

            CreateMap<CreateBookRequestModel, BookDTO>();
            CreateMap<UpdateBookRequestModel, BookDTO>();
            CreateMap<BookDTO, BookResponseModel>();

            CreateMap<CreateTagRequestModel, TagDTO>();
            CreateMap<UpdateTagRequestModel, TagDTO>();
            CreateMap<TagDTO, TagResponseModel>();

            CreateMap<CreateBookTagRequestModel, BookTagDTO>();
            CreateMap<UpdateBookTagRequestModel, BookTagDTO>();
            CreateMap<BookTagDTO, BookTagResponseModel>();
        }
    }
}
