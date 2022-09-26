using ECommerce.Shared.Contracts;
using ECommerce.Shared.Contracts.UnitsOfWork;
using ECommerce.Shared.Entities;

namespace ECommerce.Shared.UnitsOfWork;
public class ProductUnitOfWork : BaseUnitOfWork<Product>, IProductUnitOfWork
{
    public ProductUnitOfWork(IProductRepository repo) : base(repo)
    {
    }
}