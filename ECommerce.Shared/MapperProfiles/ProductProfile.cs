using AutoMapper;
using ECommerce.Shared.Dtos;
using ECommerce.Shared.Entities;

namespace ECommerce.Shared.MapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }
    }
}