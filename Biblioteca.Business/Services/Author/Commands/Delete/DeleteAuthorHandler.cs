using Biblioteca.Core.Interfaces;
using Biblioteca.Core.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Commands.Delete;
public class DeleteAuthorHandler(IRepository<Autor> repositoryAutor,IRepository<Libro> repositoryLibro) : IRequestHandler<DeleteAuthor>
{
    public async Task Handle(DeleteAuthor request, CancellationToken cancellationToken)
    {
        var author = await repositoryAutor.Query.Include(x=>x.Libros).FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
        author.Libros.ForEach(x =>
        {
            x.AutorId = null;
            //x.Autor = null;
        }); 
        repositoryAutor.Delete(author);
        await repositoryAutor.SaveChangesAsync();
    }
}
