using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Entitys.BaseEntity;
using Data.Entitys.Base;
public class ProductGroup:BaseEntity
{
    public String name { get; set; }
    
    public List<Product> Products { get; set; }
}

public class ProductGroupConfiguration : IEntityTypeConfiguration<ProductGroup>
{
    public void Configure(EntityTypeBuilder<ProductGroup> builder)
    {
        builder.HasMany(p => p.Products).WithOne(p => p.ProductGroup);
    }
}