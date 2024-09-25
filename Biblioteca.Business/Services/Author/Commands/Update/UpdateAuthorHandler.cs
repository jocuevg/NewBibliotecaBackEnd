using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Business.Services.Author.Commands.Update;
public class UpdateAuthorHandler(IRepository<Autor> repository, IRepository<Libro> libroRepository,IValidator<UpdateAuthor> validator) : IRequestHandler<UpdateAuthor>
{
    public async Task Handle(UpdateAuthor request, CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request);
        if (!validationResult.IsValid)
        {
            throw new FormatException(validationResult.ToString());
        }
        var author = await repository.Query.Include(x => x.Libros).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        author.Nombre = request.Nombre;
        author.Apellidos = request.Apellidos;
        author.Edad = request.Edad;
        await repository.SaveChangesAsync();
    }
}
