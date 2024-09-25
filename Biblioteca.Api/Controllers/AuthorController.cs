using Biblioteca.Business.Services.Author.Commands.Create;
using Biblioteca.Business.Services.Author.Commands.Delete;
using Biblioteca.Business.Services.Author.Commands.Update;
using Biblioteca.Business.Services.Author.Queries.GetAll;
using Biblioteca.Business.Services.Author.Queries.GetById;
using Biblioteca.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthorController : BaseApiController
{
    [HttpGet("All")]
    public async Task<List<AutorSummarizedDto>> GetAllAuthorsAsync()
    {
        return await Mediator.Send(new GetAllAuthors());
    }

    [HttpGet("{id}")]
    public async Task<AutorDto> GetAuthorByIdAsync(int id)
    {
        return await Mediator.Send(new GetAuthorById() { Id = id });
    }

    [HttpPost]
    public async Task<int> Create(CreateAuthor createauthor)
    {
        return await Mediator.Send(createauthor);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await Mediator.Send(new DeleteAuthor() { Id = id });
    }

    [HttpPut("{id}")]
    public async Task Update(int id, UpdateAuthorRequest updateauthor)
    {
        await Mediator.Send(new UpdateAuthor()
        {
            Id = id,
            Nombre = updateauthor.Nombre,
            Apellidos = updateauthor.Apellidos,
            Edad = updateauthor.Edad,
        });
    }
}
