using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Commands.Create;
public class CreateAuthorHandler(IRepository<Autor> repository,IValidator<CreateAuthor> validator) : IRequestHandler<CreateAuthor, int>
{
    public async Task<int> Handle(CreateAuthor request, CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request);
        if (!validationResult.IsValid)
        {
            throw new FormatException(validationResult.ToString());
        }
        var author = new Autor
        {
            Nombre = request.Nombre,
            Apellidos = request.Apellidos,
            Edad =request.Edad,
        };
        repository.Add(author);
        await repository.SaveChangesAsync();
        return author.Id;
    }
}
