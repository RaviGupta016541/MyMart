using AutoMapper;
using MyMart.API.DTOs;
using MyMart.Core.Entities;

namespace MyMart.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));

            CreateMap<CreateProductDto, Product>();
        }
    }
}
