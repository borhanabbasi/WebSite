using System.Reflection;
using Core.Extentions;
using Data.Entitys.Base;
using Data.Entitys.BaseEntity;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class StoreContext(DbContextOptions<StoreContext> option):DbContext(option)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var asm = typeof(IBaseEntity).Assembly;
        
        modelBuilder.AddEntities<BaseEntity>(asm);
        modelBuilder.ApplyConfigurationsFromAssembly(asm);
        base.OnModelCreating(modelBuilder);
    }
}