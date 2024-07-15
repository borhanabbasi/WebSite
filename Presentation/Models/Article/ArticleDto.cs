using Data.AutoMaper;

namespace WebApplication1.Models.Article;

public class ArticleDto:BaseDto<int,Data.Entitys.BaseEntity.Article,ArticleDto>
{
    public String title { get; set; }
    public String  text { get; set; }
}