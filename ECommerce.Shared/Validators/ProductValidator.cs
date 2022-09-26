using ECommerce.Shared.Entities;
using FluentValidation;

namespace ECommerce.Shared.Validators;
public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        // RuleFor(p => p.Price).NotEmpty().WithMessage("Price is required");
        // RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
        // RuleFor(p => p.Description).NotEmpty().WithMessage("Description is required");
        // RuleFor(p => p.Description).MaximumLength(1000).WithMessage("Description must not exceed 1000 characters");
        // RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category is required");
        // RuleFor(p => p.CoverTypeId).NotEmpty().WithMessage("Cover type is required");
    }
}