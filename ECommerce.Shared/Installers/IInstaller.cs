using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Shared.Installers;
public interface IInstaller
{
    void InstallServices(IServiceCollection services, IConfiguration configuration);
}