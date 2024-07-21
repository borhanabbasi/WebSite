using Data.Repositorys.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.ProductGroup;

public class ProductGroup(StoreContext context) :RepositoryGeneric<Entitys.BaseEntity.ProductGroup>(context),IProductGroup
{
    
}