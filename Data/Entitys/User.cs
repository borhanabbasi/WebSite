
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Data.Entitys.Base;
using Data.Entitys.BaseEntity;

namespace Data.Entitys.Base;

public class User:BaseEntity<Guid>
{
    public string name{ get; set; }
    public String address { get; set; }
    public String  username { get; set; }
    public String  pasword { get; set; }
    public String  phone { get; set; }


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
