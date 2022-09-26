using ECommerce.Shared.Contracts;
using ECommerce.Shared.Contracts.UnitsOfWork;
using ECommerce.Shared.Repositories;
using ECommerce.Shared.UnitsOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace ECommerce.Shared.Installers;
public class ProductInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductUnitOfWork, ProductUnitOfWork>();
    }
}