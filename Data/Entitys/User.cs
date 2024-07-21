
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Data.Entitys.Base;
using Data.Entitys.BaseEntity;

namespace Data.Entitys.Base;

public class User:BaseEntity
{
    public string? Name { get; set; } = "";
    public String Address { get; set; }
    public String  Username { get; set; }
    public String  Pasword { get; set; }
    public String  Phone { get; set; }


    public List<Order> Orders { get; set; }
    public ProductBelove ProductBelove { get; set; }
    public ProductBasket ProductBasket { get; set; }
}

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasMany(p => p.Orders).WithOne(p => p.User);
        builder.HasOne<ProductBelove>(p => p.ProductBelove).WithOne(p => p.User);
        builder.HasOne<ProductBasket>(p => p.ProductBasket).WithOne(p => p.User);
            
        
    }
}
