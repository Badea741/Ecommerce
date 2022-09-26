using ECommerce.Shared.Contracts;
using ECommerce.Shared.Entities;

namespace ECommerce.Shared.Repositories;
public class ProductRepository : BaseRepo<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}