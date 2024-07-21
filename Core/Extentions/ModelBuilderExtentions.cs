using System.Reflection;
using Microsoft.EntityFrameworkCore;
namespace Core.Extentions;

public static class ModelBuilderExtentions
{
    public static void AddEntities<TBaseEntity>(this ModelBuilder modelBuilder, Assembly assembly)
    {
        
      var entitys= assembly.GetExportedTypes()
          .Where(c => c.IsClass && !c.IsAbstract && c.IsPublic && typeof(TBaseEntity).IsAssignableFrom(c));
      foreach (var entity in entitys)
          modelBuilder.Entity(entity);
      
    }
  
}