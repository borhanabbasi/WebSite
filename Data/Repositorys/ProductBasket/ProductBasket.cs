using Data.Repositorys.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.ProductBasket;

public class ProductBasket(DbContext context) :RepositoryGeneric<ProductBasket>(context),IProductBasket
{
    
}