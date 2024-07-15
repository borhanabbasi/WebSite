using AutoMapper;
using Core;

namespace Data.AutoMaper;

public class BaseDto<Tkey,Tsourse,TDest>:IHaveCustomMaping
{
    public Tkey Id { get; set; }
    public void ApplyMaping(Profile customProfile)
    {
        customProfile.CreateMap<Tsourse, TDest>().ReverseMap();
    }
}