using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Books.Commands.Create;
public class CreateLibroHandler(IRepository<Libro> repository, IValidator<CreateLibro> validator) : IRequestHandler<CreateLibro, int>
{
    public async Task<int> Handle(CreateLibro request, CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request);
        if (!validationResult.IsValid)
        {
            throw new FormatException(validationResult.ToString());
        }
        var book= new Libro
        {
            Nombre = request.Nombre,
            NumeroPaginas = request.NumeroPaginas,
            AutorId = request.AutorId,
        };
        repository.Add(book);
        await repository.SaveChangesAsync();
        return book.Id;
    }
}
