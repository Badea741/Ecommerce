using ECommerce.Shared.Contracts;
using ECommerce.Shared.Contracts.UnitsOfWork;
using ECommerce.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Shared.UnitsOfWork;
public class CategoryUnitOfWork : BaseUnitOfWork<Category>, ICategoryUnitOfWork
{
    public CategoryUnitOfWork(ICategoryRepository repo) : base(repo)
    {
    }
}