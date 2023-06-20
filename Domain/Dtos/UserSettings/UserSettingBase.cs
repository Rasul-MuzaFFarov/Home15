namespace Domain.Dtos.UserSettings;

public class UserSettingBase
{
    public int UserId { get; set; }
    public NotificationNewsletter NotificationNewsletter { get; set; }
    public NotificationFollowers NotificationFollower { get; set; }
    public NotificationComments NotificationComment { get; set; }
    public NotificationMessages NotificationMessage { get; set; }
}
public enum NotificationNewsletter
{
    On = 1,
    Off
}
public enum NotificationFollowers
{
    On = 1,
    Off
}
public enum NotificationComments
{
    On = 1,
    Off
}
public enum NotificationMessages
{
    On = 1,
    Off
}