using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.GenericRepository;

public interface IRepositoryGeneric<TEntity>  where TEntity : class
{
    public DbSet<TEntity> Entities { get; }
    public virtual IQueryable<TEntity> Table => Entities;
    public virtual IQueryable<TEntity> TableNoTracking => Entities.AsNoTracking();
    Task<TEntity> Add(TEntity entity);
    void Remove(int id);
    // List<TEntity> GetAll();
    // Task<TEntity?> GetById(int id);
    Task<TEntity> Update(TEntity entityDto);
}