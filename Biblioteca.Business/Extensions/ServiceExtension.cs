using Biblioteca.Business.Services.Author.Commands.Create;
using Biblioteca.Business.Services.Author.Commands.Update;
using Biblioteca.Business.Services.Books.Commands.Create;
using Biblioteca.Business.Services.Books.Commands.Update;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Extensions;
public static class ServiceExtension
{
    public static void AddBusinessLayer(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(ServiceExtension).Assembly);
        });
        services.AddScoped(typeof(IValidator<CreateLibro>),typeof(CreateLibroValidation));
        services.AddScoped(typeof(IValidator<UpdateLibro>), typeof(UpdateLibroValidation));
        services.AddScoped(typeof(IValidator<CreateAuthor>), typeof(CreateAuthorValidation));
        services.AddScoped(typeof(IValidator<UpdateAuthor>), typeof(UpdateAuthorValidation));
    }
}
