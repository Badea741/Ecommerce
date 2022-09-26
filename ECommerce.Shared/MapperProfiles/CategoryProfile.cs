using AutoMapper;
using ECommerce.Shared.Dtos;
using ECommerce.Shared.Entities;

namespace ECommerce.Shared.MapperProfiles;
public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryDto, Category>();
    }
}