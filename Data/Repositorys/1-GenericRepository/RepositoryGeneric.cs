using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.GenericRepository;

public class RepositoryGeneric<TEntity>(DbContext context):IRepositoryGeneric<TEntity> where TEntity:class
{
    public DbSet<TEntity> Entities { get; } = context.Set<TEntity>();
    public virtual IQueryable<TEntity> Table => Entities;
    public virtual IQueryable<TEntity> TableNoTracking => Entities.AsNoTracking();
    
    
    // public DbSet<TEntity> Table = context.Set<TEntity>();
    public async Task<TEntity> Add(TEntity entity)
    {
        await Entities.AddAsync(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async void Remove(int id)
    {
        var entity = await Entities.FindAsync(id);
        if (entity != null)
        {
            Entities.Remove(entity);
            await context.SaveChangesAsync();
        }
    }

    // public List<TEntity> GetAll()
    // {
    //     var entitys =  Entities.AsNoTracking().ToList();
    //     return entitys;
    // }
    //
    // public async Task<TEntity?> GetById(int id)
    // {
    //     var entity = await Entities.FindAsync(id);
    //     return entity;
    // }

    public async Task<TEntity> Update(TEntity entity)
    {
        Entities.Update(entity);
        await context.SaveChangesAsync();
        return entity;
    }
}