using Biblioteca.Core.Interfaces;
using Biblioteca.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Biblioteca.Infraestructure.Extensions;
public static class ServiceExtension
{
    public static void ConfigureInfraestructure(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}
