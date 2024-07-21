using Data.Repositorys.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.ProductBelove;

public class PorductBelove(StoreContext context) :RepositoryGeneric<Entitys.BaseEntity.ProductBelove>(context),IPorductBelove
{
    
}