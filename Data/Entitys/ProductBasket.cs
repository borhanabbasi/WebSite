using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Entitys.BaseEntity;
using Data.Entitys.Base;
public class ProductBasket:BaseEntity
{
    public int UserId { get; set; }

    public List<Product> Products { get; set; }
    public User User { get; set; } 
}
public class ProductBasketConfiguration : IEntityTypeConfiguration<ProductBasket>
{
    public void Configure(EntityTypeBuilder<ProductBasket> builder)
    {
        builder.HasMany(p => p.Products).WithMany(p => p.ProductBaskets);
        builder.HasOne<User>(p => p.User).WithOne(p => p.ProductBasket).HasForeignKey<User>(k=>k.Id);

    }
}
