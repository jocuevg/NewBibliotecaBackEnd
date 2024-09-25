using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Books.Commands.Delete;
public class DeleteLibro : IRequest
{
    public int Id { get; set; }
}
