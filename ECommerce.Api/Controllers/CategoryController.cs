using AutoMapper;
using CommonGenericClasses;
using ECommerce.Shared.Contracts.UnitsOfWork;
using ECommerce.Shared.Dtos;
using ECommerce.Shared.Entities;
using FluentValidation;

namespace ECommerce.Api.Controllers;
public class CategoryController : BaseController<Category, CategoryDto>
{
    public CategoryController(ICategoryUnitOfWork unitOfWork, IMapper mapper, IValidator<Category> validator) : base(unitOfWork, mapper, validator)
    {
    }
}