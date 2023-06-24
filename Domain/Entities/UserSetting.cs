using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class UserSetting
{
    [Key]
    public int UserId { get; set; }
    public int NotificationNewsletter { get; set; }
    public int NotificationFollower { get; set; }
    public int NotificationComment { get; set; }
    public int NotificationMessage { get; set; }
    public User User { get; set; }
}

