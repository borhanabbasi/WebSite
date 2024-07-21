using AutoMapper;
using Core;
using Data.AutoMaper;

namespace WebApplication1.Models.Article;

public class ArticleSelectDto:IHaveCustomMaping
{
    public int Id { get; set; }
    public String title { get; set; }
    public String  text { get; set; }
    public void ApplyMaping(Profile customProfile)
    {
        customProfile.CreateMap<Data.Entitys.BaseEntity.Article, ArticleSelectDto>().ReverseMap();
    }
}