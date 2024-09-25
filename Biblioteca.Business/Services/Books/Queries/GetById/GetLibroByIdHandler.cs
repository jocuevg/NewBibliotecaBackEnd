using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Business.Services.Books.Queries.GetById;
public class GetLibroByIdHandler(IRepository<Libro> repository) : IRequestHandler<GetLibroById, LibroDto>
{
    public async Task<LibroDto> Handle(GetLibroById request, CancellationToken cancellationToken)
    {
        var book = await repository.Query.Include(x => x.Autor).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (book is null)
        {
            throw new KeyNotFoundException($"No se ha encontrado el libro con id: {request.Id}");
        }
        else
        {
            return new LibroDto
            {
                Id = book.Id,
                Nombre = book.Nombre,
                NumeroPaginas = book.NumeroPaginas,
                AutorId = book.AutorId,
                Autor = book.Autor is null ? null : new AutorSummarizedDto
                {
                    Id = book.Autor.Id,
                    Nombre = book.Autor.Nombre,
                    Apellidos = book.Autor.Apellidos,
                    Edad = book.Autor.Edad,
                }
            };

        }

    }
}
