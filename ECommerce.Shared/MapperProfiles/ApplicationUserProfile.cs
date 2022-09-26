using AutoMapper;
using ECommerce.Shared.Dtos;
using ECommerce.Shared.Entities;

namespace ECommerce.Shared.MapperProfiles;
public class ApplicationUserProfile : Profile
{
    public ApplicationUserProfile()
    {
        CreateMap<ApplicationUser, ApplicationUserDto>();
        CreateMap<ApplicationUserDto, ApplicationUser>();
    }
}