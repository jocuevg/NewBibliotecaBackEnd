using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Commands.Delete;
public class DeleteAuthor : IRequest
{
    public int Id { get; set; }
}
