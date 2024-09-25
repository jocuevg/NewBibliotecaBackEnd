using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Books.Queries.GetAll;
public class GetAllLibrosHandler(IRepository<Libro> repository) : IRequestHandler<GetAllLibros, List<LibroSummarizedDto>>
{
    public async Task<List<LibroSummarizedDto>> Handle(GetAllLibros request, CancellationToken cancellationToken)
    {
        return await repository.Query.Select(x=>new LibroSummarizedDto
        {
            Id=x.Id,
            Nombre=x.Nombre,
            NumeroPaginas=x.NumeroPaginas,
            AutorId=x.AutorId,
        }).ToListAsync(cancellationToken);
    }
}
