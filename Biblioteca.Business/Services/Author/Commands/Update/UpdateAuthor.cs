using Biblioteca.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Commands.Update;
public class UpdateAuthor : IRequest
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public int Edad {  get; set; }
}

public class UpdateAuthorRequest
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; }
}