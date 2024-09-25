using Biblioteca.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Books.Commands.Update;
public class UpdateLibro : IRequest
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int NumeroPaginas { get; set; }
    public int? AutorId { get; set; }
}

public class UpdateLibroRequest
{
    public string Nombre { get; set; }
    public int NumeroPaginas { get; set; }
    public int? AutorId { get; set; }
}
