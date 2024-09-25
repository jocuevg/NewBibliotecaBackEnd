using Biblioteca.Business.Services.Books.Commands.Create;
using Biblioteca.Business.Services.Books.Commands.Delete;
using Biblioteca.Business.Services.Books.Commands.Update;
using Biblioteca.Business.Services.Books.Queries.GetAll;
using Biblioteca.Business.Services.Books.Queries.GetById;
using Biblioteca.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : BaseApiController
{ 
    [HttpGet("All")]
    public async Task<List<LibroSummarizedDto>> GetAllLibrosAsync()
    {
        return await Mediator.Send(new GetAllLibros());
    }

    [HttpGet("{id}")]
    public async Task<LibroDto> GetLibroByIdAsync(int id)
    {
        return await Mediator.Send(new GetLibroById() { Id=id});
    }

    [HttpPost]
    public async Task<int> Create(CreateLibro createlibro)
    {
        return await Mediator.Send(createlibro);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await Mediator.Send(new DeleteLibro() { Id=id});
    }

    [HttpPut("{id}")]
    public async Task Update(int id,UpdateLibroRequest updatelibro)
    {
        await Mediator.Send(new UpdateLibro() { 
            Id = id,
            Nombre= updatelibro.Nombre,
            NumeroPaginas=updatelibro.NumeroPaginas,
            AutorId = updatelibro.AutorId
        });
    }
}
