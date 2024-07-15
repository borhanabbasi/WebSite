using System.Reflection;
using Microsoft.EntityFrameworkCore;
namespace Core.Extentions;

public static class ModelBuilderExtentions
{
    public static void AddEntities<TBaseEntity>(this ModelBuilder modelBuilder, Assembly assembly)
    {
        
      var entitys=assembly.GetTypes()
          .Where(p =>p.IsClass &&  p.IsSubclassOf(typeof(TBaseEntity)) && !p.IsInterface);
      foreach (var entity in entitys)
      {
          modelBuilder.Entity(entity);
      }
    }
}