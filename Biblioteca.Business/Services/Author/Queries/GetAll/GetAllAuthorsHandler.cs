using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Queries.GetAll;
public class GetAllAuthorsHandler(IRepository<Autor> repository) : IRequestHandler<GetAllAuthors, List<AutorSummarizedDto>>
{
    public async Task<List<AutorSummarizedDto>> Handle(GetAllAuthors request, CancellationToken cancellationToken)
    {
        return await repository.Query.Select(x=> new AutorSummarizedDto
        {
            Id = x.Id,
            Nombre = x.Nombre,
            Apellidos = x.Apellidos,
            Edad = x.Edad,
        }).ToListAsync(cancellationToken);
    }
}
