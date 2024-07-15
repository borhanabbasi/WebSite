using Data.AutoMaper;

namespace WebApplication1.Models.User;

public class UserDto:BaseDto<int,UserDto,Data.Entitys.Base.User>
{
    public string name{ get; set; }
    public String address { get; set; }
    public String  username { get; set; }
    public String  pasword { get; set; }
    public String  phone { get; set; }
}