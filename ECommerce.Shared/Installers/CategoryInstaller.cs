using ECommerce.Shared.Contracts;
using ECommerce.Shared.Contracts.UnitsOfWork;
using ECommerce.Shared.Repositories;
using ECommerce.Shared.UnitsOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Shared.Installers;
public class CategoryInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICategoryUnitOfWork, CategoryUnitOfWork>();

    }
}