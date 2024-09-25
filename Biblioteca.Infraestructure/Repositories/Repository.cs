using Biblioteca.Core.Interfaces;
using Biblioteca.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infraestructure.Repositories;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly BibliotecaDBContext context;
    public DbSet<TEntity> Table { get;}

    public Repository(BibliotecaDBContext context)
    {
        this.context = context;
        Table = context.Set<TEntity>();
    }

    public IQueryable<TEntity> Query => Table;

    public void Add(TEntity entity) => Table.Add(entity);

    public void Delete(TEntity entity) => Table.Remove(entity);

    public async Task SaveChangesAsync() => await context.SaveChangesAsync();

    public void Update(TEntity entity) => Table.Update(entity);

    public void Attach(TEntity entity) => Table.Attach(entity);
}
