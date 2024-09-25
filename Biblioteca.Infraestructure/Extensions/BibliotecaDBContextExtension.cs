using Biblioteca.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infraestructure.Extensions;
public static class BibliotecaDBContextExtension
{
    public static void AddCustomBibliotecaDBContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BibliotecaDBContext>(options =>
        {
            options.UseSqlServer(
               configuration.GetConnectionString("Biblioteca"),
               b => b.MigrationsAssembly(typeof(BibliotecaDBContext).Assembly.FullName).CommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds));
        });
    }
}
