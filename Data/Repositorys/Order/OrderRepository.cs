using Data.Repositorys.Article;
using Data.Repositorys.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.Order;

public class OrderRepository(DbContext context) :RepositoryGeneric<Entitys.BaseEntity.Order>(context),IOrderRepository
{
    
}