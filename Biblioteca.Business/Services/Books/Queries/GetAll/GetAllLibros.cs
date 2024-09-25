using Biblioteca.Core.Models;
using MediatR;

namespace Biblioteca.Business.Services.Books.Queries.GetAll;
public class GetAllLibros : IRequest<List<LibroSummarizedDto>>
{
}
