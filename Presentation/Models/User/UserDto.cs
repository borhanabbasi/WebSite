using Data.AutoMaper;

namespace WebApplication1.Models.User;

public class UserDto:BaseDto<int,UserDto,Data.Entitys.Base.User>
{
    public string? Name { get; set; } = "";
    public String Address { get; set; }
    public String  Username { get; set; }
    public String  Pasword { get; set; }
    public String  Phone { get; set; }
}