using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AuthenticationServices.Installers;

namespace ECommerce.Shared.Installers;
public class AuthenticationServicesInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthenticationServices(configuration);
    }
}