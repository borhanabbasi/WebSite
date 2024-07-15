using Core.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Entitys.BaseEntity;
using Data.Entitys.Base;
public class Order:BaseEntity
{
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public int Descount { get; set; }
    public OrderEnum.ordercondition condition { get; set; }
    public long PostPrice { get; set; }
    public long Price { get; set; }
    public string OrderCode { get; set; }
    public string TrackingCode { get; set; }

    public List<OrderDetail> OrderDetails { get; set; }
    public User User { get; set; }
}
public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasOne<User>(p => p.User).WithMany(p => p.Orders);
        builder.HasMany(p => p.OrderDetails).WithOne(p => p.Order);
    }
}
