using ECommerce.Shared.Contracts;
using ECommerce.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Shared.Repositories;
public class CategoryRepository : BaseRepo<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext db) : base(db)
    {
    }
}