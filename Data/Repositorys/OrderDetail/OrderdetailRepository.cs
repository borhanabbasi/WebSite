using Data.Repositorys.GenericRepository;
using Data.Repositorys.Order;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.OrderDetail;

public class OrderdetailRepository(StoreContext context) :RepositoryGeneric<OrderRepository>(context),IOrderdetailRepository
{
    
}