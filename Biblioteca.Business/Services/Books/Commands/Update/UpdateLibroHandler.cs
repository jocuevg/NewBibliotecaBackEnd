using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Business.Services.Books.Commands.Update;
public class UpdateLibroHandler(IRepository<Libro> repository, IValidator<UpdateLibro> validator) : IRequestHandler<UpdateLibro>
{
    public async Task Handle(UpdateLibro request, CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request);
        if (!validationResult.IsValid)
        {
            throw new FormatException(validationResult.ToString());
        }
        var book = await repository.Query.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        book.Nombre = request.Nombre;
        book.NumeroPaginas = request.NumeroPaginas;
        book.AutorId = request.AutorId;
        await repository.SaveChangesAsync();
    }
}
