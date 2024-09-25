using Biblioteca.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Queries.GetById;
public class GetAuthorById : IRequest<AutorDto>
{
    public int Id { get; set; }
}
