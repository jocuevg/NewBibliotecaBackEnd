using Biblioteca.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Commands.Create;
public class CreateAuthor : IRequest<int>
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; }
}
