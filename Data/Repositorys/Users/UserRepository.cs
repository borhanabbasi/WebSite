using Data.Repositorys;
using Data.Repositorys;
using Data.Entitys;
using Data.Entitys.Base;
using Data.Entitys.BaseEntity;
using Data.Repositorys.GenericRepository;

namespace Data.Repositorys;
using Data.Entitys;
public class UserRepository(StoreContext context) :RepositoryGeneric<User>(context), IUserRepository
{
    
}