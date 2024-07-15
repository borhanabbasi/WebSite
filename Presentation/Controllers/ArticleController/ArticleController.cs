using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entitys.BaseEntity;
using Data.Repositorys;
using Data.Repositorys.GenericRepository;
using Microsoft.AspNetCore.Components.Forms.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Article;

namespace WebApplication1.Controllers.ArticleController;
[ApiController]
[Route("[Controller]/[action]")]
public class ArticleController(IRepositoryGeneric<Article> _articlerepository,IMapper _mapper) : ControllerBase
{
    // List<ArticleSelectDto> models;
    [HttpGet]
    public  ActionResult<List<ArticleSelectDto>>  GetAllArticle()
    {
        
        // var mmmm=_articlerepository.GetAll();
        // foreach (var item in mmmm)
        // {
        //    var i= _mapper.Map<ArticleSelectDto>(item);
        //    models.Add(i);
        // }
        //
        // return models;
        var model = _articlerepository.TableNoTracking.ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider);
        return Ok(model);
    }
    [HttpGet]
    public  ActionResult<List<ArticleSelectDto>>  GetArticleById(int id)
    {
        var item = _articlerepository.TableNoTracking
            .ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider).FirstOrDefault(p=>p.Id==id);
        return Ok(item);
    }
    [HttpPost]
    public  ActionResult<ArticleSelectDto> CreateArticle(ArticleDto dto)
    {
       var model= _mapper.Map<Article>(dto);
        _articlerepository.Add(model);
       // return Ok(_mapper.Map<ArticleSelectDto>(model)) ;
       var item = _articlerepository.TableNoTracking.ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider)
           .FirstOrDefault(p => p.Id == model.Id);  
        return Ok(item);
    }
    [HttpDelete]
    public  ActionResult<ArticleSelectDto> RemoveArticle(int id)
    {
        _articlerepository.Remove(id);
        var item = _articlerepository.TableNoTracking.ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider)
            .FirstOrDefault(p => p.Id == id);  
        return Ok(item);
    }
    [HttpPut]
    public  ActionResult<ArticleSelectDto> EditeArticle(ArticleDto dto)
    {
        var model= _mapper.Map<Article>(dto);
        _articlerepository.Update(model);
        var item = _articlerepository.TableNoTracking.ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider)
            .FirstOrDefault(p => p.Id ==dto.Id);  
        return Ok(item);
    }
    
    
}