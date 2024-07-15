using Data.Repositorys.Article;
using Data.Repositorys.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys;
using Data.Entitys;
public class ArticleRepository(DbContext context) :RepositoryGeneric<Entitys.BaseEntity.Article>(context),IArticleRepository
{
    
}