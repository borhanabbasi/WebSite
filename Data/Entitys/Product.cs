using Data.Entitys.BaseEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Net.Mime.MediaTypeNames;

namespace Data.Entitys.BaseEntity;
using Data.Entitys.Base;
public class Product:BaseEntity
{
    public int ProductGroupId { get; set; }
    public String name { get; set; }
    public String picturePath { get; set; }
    public long price { get; set; }
    
    public List<ProductBasket> ProductBaskets { get; set; }
    public List<ProductBelove> ProductBeloves { get; set; }
    public ProductGroup ProductGroup { get; set; }
}
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {

        builder.HasMany(p => p.ProductBeloves)
            .WithMany(p => p.Products); 
        builder.HasMany(p => p.ProductBaskets)
            .WithMany(p => p.Products);
        builder.HasOne<ProductGroup>().WithMany(p => p.Products);
    }
}