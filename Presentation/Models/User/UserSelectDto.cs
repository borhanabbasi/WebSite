using Data.AutoMaper;

namespace WebApplication1.Models.User;

public class UserSelectDto:BaseDto<int,UserSelectDto,Data.Entitys.Base.User>
{
    public Guid Id { get; set; }
    public string name{ get; set; }
    public String address { get; set; }
    public String  phone { get; set; }
}