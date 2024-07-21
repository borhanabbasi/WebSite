using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.GenericRepository;

public class RepositoryGeneric<TEntity> : IRepositoryGeneric<TEntity> where TEntity : class
{
    public DbSet<TEntity> Entities { get; }
    protected readonly StoreContext DbContext;
    public virtual IQueryable<TEntity> Table => Entities;
    public virtual IQueryable<TEntity> TableNoTracking => Entities.AsNoTracking();

    public RepositoryGeneric(StoreContext dbContext)
    {
        
        DbContext = dbContext;
        Entities = dbContext.Set<TEntity>();
    }
    
    public async Task<TEntity> Add(TEntity entity)
    {
        await Entities.AddAsync(entity);
        DbContext.SaveChanges();
        return entity;

    }

    public async Task Remove(int id)

    {
        var entity =await Entities.FindAsync(id);
        if (entity != null)
        {
            Entities.Remove(entity);
           await DbContext.SaveChangesAsync();
        }

        
    }

    public List<TEntity> GetAll()
    {
        var entitys = Entities.AsNoTracking().ToList();
        return entitys;
    }

    public async Task<TEntity?> GetById(int id)
    {
        var entity = await Entities.FindAsync(id);
        return entity;
    }

    public void Update(TEntity entity)
    {
        Entities.Update(entity);
         DbContext.SaveChanges();
    }
}