using ECommerce.Shared.Entities;
using CommonGenericClasses;
using AutoMapper;
using FluentValidation;
using ECommerce.Shared.Dtos;
using ECommerce.Shared.Contracts.UnitsOfWork;

namespace ECommerce.Api.Controllers;
public class ProductController : BaseController<Product, ProductDto>
{
    public ProductController(IProductUnitOfWork unitOfWork, IMapper mapper, IValidator<Product> validator) : base(unitOfWork, mapper, validator)
    {
    }
}