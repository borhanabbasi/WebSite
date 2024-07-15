using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Entitys.BaseEntity;
using Data.Entitys.Base;
public class OrderDetail:BaseEntity
{
    public int OrderId { get; set; }
    public int Number { get; set; }
    public int ProductId { get; set; }
    public long Price { get; set; }
    public int Descount  { get; set; }

    public Order Order { get; set; }
}
public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.HasOne<Order>(p => p.Order).WithMany(p => p.OrderDetails);
    }
}