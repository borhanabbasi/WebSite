using AutoMapper;
using Core;
using Data.AutoMaper;

namespace WebApplication1.Models.User;

public class UserSelectDto:IHaveCustomMaping
{
    public string? Name { get; set; } = "";
    public String Address { get; set; }
    public String  Phone { get; set; }
    public void ApplyMaping(Profile customProfile)
    {
        customProfile.CreateMap<UserSelectDto, Data.Entitys.Base.User>().ReverseMap();
    }
}