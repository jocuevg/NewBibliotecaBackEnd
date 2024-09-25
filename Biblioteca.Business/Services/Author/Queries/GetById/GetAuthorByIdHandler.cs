using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Queries.GetById;
public class GetAuthorByIdHandler(IRepository<Autor> repository) : IRequestHandler<GetAuthorById, AutorDto>
{
    public async Task<AutorDto> Handle(GetAuthorById request, CancellationToken cancellationToken)
    {
        var author = await repository.Query.Include(x=>x.Libros).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        return new AutorDto
        {
            Id = author.Id,
            Nombre = author.Nombre,
            Apellidos = author.Apellidos,
            Edad = author.Edad,
            Libros=author.Libros.Select(x=>x.Id).ToList(),
        };
    }
}
