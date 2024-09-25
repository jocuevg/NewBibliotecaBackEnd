using Biblioteca.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infraestructure.Context;

public class BibliotecaDBContext : DbContext
{
    public BibliotecaDBContext(DbContextOptions<BibliotecaDBContext> options) : base(options)
    {
    }
    public DbSet<Libro> Libros { get; set; }
    public DbSet<Autor> Autores { get; set; }
}
