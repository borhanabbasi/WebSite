using Data.Repositorys.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys.ProductBelove;

public class PorductBelove(DbContext context) :RepositoryGeneric<Entitys.BaseEntity.ProductBelove>(context),IPorductBelove
{
    
}