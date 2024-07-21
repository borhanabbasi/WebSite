using Data.Entitys.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Entitys.BaseEntity;
using Data.Entitys;
public class Article:Base.BaseEntity
{
    public String title { get; set; }
    public String  text { get; set; }
}

