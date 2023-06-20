namespace Domain.Dtos.UserProfiles;

public class UserProfileBase
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int LocationId { get; set; }
    public Char Gender { get; set; }
    public DateTime DOB { get; set; }
    public string Occupation { get; set; }
    public string About { get; set; }
    public DateTime DateTime { get; set; }
}