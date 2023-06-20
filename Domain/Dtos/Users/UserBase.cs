namespace Domain.Dtos.Users;

public class UserBase
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PasswordSalt { get; set; }
    public DateTime DateRegistered { get; set; }
    public string UserType { get; set; }
    public string AccountStatus { get; set; }
}