using Biblioteca.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Books.Queries.GetById;
public class GetLibroById : IRequest<LibroDto>
{
    public int Id { get; set; }
}
