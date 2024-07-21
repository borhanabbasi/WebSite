using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.AutoMaper;
using Data.Entitys.BaseEntity;
using Data.Repositorys;
using Data.Repositorys.Article;
using Data.Repositorys.GenericRepository;
using Microsoft.AspNetCore.Components.Forms.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Article;

namespace WebApplication1.Controllers.ArticleController;
[ApiController]
[Route("[Controller]/[action]")]
public class ArticleController(IArticleRepository _articlerepository,IMapper _mapper) : ControllerBase
{
    // List<ArticleSelectDto> models;
    [HttpGet]
    public  ActionResult<List<ArticleSelectDto>>  GetAllArticle()
    {
        var model = _articlerepository.TableNoTracking.ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider).ToList();
        return Ok(model);
    }
    [HttpGet]
    public  ActionResult<List<ArticleSelectDto>>  GetArticleById(int id)
    {
        var item = _articlerepository.TableNoTracking
            .ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider).FirstOrDefault(p=>p.Id==id);
        if (item == null)
            return NotFound();
        return Ok(item);
    }
    [HttpPost]
    public  ActionResult<ArticleSelectDto> CreateArticle(ArticleDto dto)
    {
       var model= _mapper.Map<Article>(dto);
       var res= _articlerepository.Add(model).Result;
       var item = _mapper.Map<ArticleSelectDto>(res);
       // var item = _articlerepository.TableNoTracking.ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider)
       //     .FirstOrDefault(x => x.Id == model.Id);
        return Ok(_mapper.Map<ArticleSelectDto>(item));
    }
    [HttpDelete]
    public  IActionResult RemoveArticle(int id)
    {
        var item = _articlerepository.TableNoTracking.ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider)
            .FirstOrDefault(x => x.Id == id);
        if (item == null)
            return NotFound();
        _articlerepository.Remove(id);
        return Ok();
    }
    [HttpPut]
    public  ActionResult<ArticleSelectDto> EditeArticle(ArticleDto dto)
    {
        var model= _mapper.Map<Article>(dto);
        if (model == null)
            return NotFound();
        _articlerepository.Update(model);
        var item = _articlerepository.TableNoTracking.ProjectTo<ArticleSelectDto>(_mapper.ConfigurationProvider)
            .FirstOrDefault(p => p.Id ==dto.Id);  
        return Ok(item);
    }
    
    
}