using Biblioteca.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Queries.GetAll;
public class GetAllAuthors : IRequest<List<AutorSummarizedDto>>
{
}
