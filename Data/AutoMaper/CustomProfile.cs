using System.Reflection;
using AutoMapper;
using Core;

namespace Data.AutoMaper;

public class CustomProfile:Profile
{
    public CustomProfile()
    {
        var alltype = Assembly.GetEntryAssembly()!.GetExportedTypes();
        var typeDtos = alltype.Where(p => p is { IsAbstract: false, IsClass: true, IsPublic: true }
                                         && typeof(IHaveCustomMaping).IsAssignableFrom(p));
        
        
        foreach (var type in typeDtos)
        {
            var creatMapping = Activator.CreateInstance(type) as IHaveCustomMaping;
            creatMapping!.ApplyMaping(this);
        }
    }
}