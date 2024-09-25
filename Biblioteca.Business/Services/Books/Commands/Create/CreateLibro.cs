using Biblioteca.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Biblioteca.Business.Services.Books.Commands.Create;
public class CreateLibro : IRequest<int>
{
    public string Nombre { get; set; }
    public int NumeroPaginas { get; set; }
    public int? AutorId { get; set; }
}
