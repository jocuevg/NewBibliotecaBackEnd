using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Books.Commands.Delete;
public class DeleteLibroHandler(IRepository<Libro> repositoy) : IRequestHandler<DeleteLibro>
{
    public async Task Handle(DeleteLibro request, CancellationToken cancellationToken)
    {
        var book = await repositoy.Query.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        repositoy.Delete(book);
        await repositoy.SaveChangesAsync();
    }
}
