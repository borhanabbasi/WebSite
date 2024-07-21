using Data;
using Data.AutoMaper;
using Data.Entitys.BaseEntity;
using Data.Repositorys;
using Data.Repositorys.Article;
using Data.Repositorys.GenericRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(CustomProfile));
builder.Services.AddScoped(typeof(IRepositoryGeneric<>), typeof(RepositoryGeneric<>));
builder.Services.AddScoped(typeof(IArticleRepository), typeof(ArticleRepository));



var conString=builder.Configuration.GetConnectionString("store");
builder.Services.AddDbContext<StoreContext>(option => option.UseSqlServer(conString));
builder.Services.AddSwaggerGen();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllers();

app.Run();