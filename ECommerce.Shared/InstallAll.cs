using ECommerce.Shared.Dtos;
using ECommerce.Shared.Installers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Shared;
public static class Installer
{
    public static void InstallAll(this IServiceCollection services, IConfiguration configuration)
    {
        var installers = typeof(ProductDto).Assembly.DefinedTypes
            .Where(x => typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
            .Select(Activator.CreateInstance).Cast<IInstaller>().ToList();
        foreach (IInstaller installer in installers)
        {
            installer.InstallServices(services, configuration);
        }
    }
}