using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Core.Interfaces;
public interface IRepository<TEntity> where TEntity : class
{
    IQueryable<TEntity> Query { get; }
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void Attach(TEntity entity);
    public Task SaveChangesAsync();
}
