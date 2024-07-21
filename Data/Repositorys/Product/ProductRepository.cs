using Data.Repositorys.GenericRepository;
using Data.Repositorys.Order;
using Data.Repositorys.OrderDetail;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.Product;

public class ProductRepository(StoreContext context) :RepositoryGeneric<Entitys.BaseEntity.Product>(context),IProductRepository
{
    
}