using Data.Repositorys.Article;
using Data.Repositorys.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorys;
using Data.Entitys.BaseEntity;
public class ArticleRepository(StoreContext context) :RepositoryGeneric<Entitys.BaseEntity.Article>(context),IArticleRepository;