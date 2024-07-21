using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Entitys.BaseEntity;
using Data.Entitys.Base;
public class ProductBelove:BaseEntity
{
    public int UserId { get; set; }
    
    public List<Product> Products { get; set; }
    public User User { get; set; }
}

public class ProductBeloveConfiguration : IEntityTypeConfiguration<ProductBelove>
{
    public void Configure(EntityTypeBuilder<ProductBelove> builder)
    {
        builder.HasMany(p => p.Products).WithMany(p => p.ProductBeloves);
        builder.HasOne<User>(p => p.User).WithOne(p => p.ProductBelove).HasForeignKey<User>(k=>k.Id);

    }
}