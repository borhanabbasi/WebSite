using Data.AutoMaper;

namespace WebApplication1.Models.Article;

public class ArticleSelectDto:BaseDto<int,ArticleDto,Data.Entitys.BaseEntity.Article>
{
    public int Id { get; set; }
    public String title { get; set; }
    public String  text { get; set; }
}