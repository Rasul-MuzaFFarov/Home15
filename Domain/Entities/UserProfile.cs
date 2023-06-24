using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class UserProfile
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    [MaxLength(45)]
    public string FirstName { get; set; }
    [MaxLength(45)]
    public string LastName { get; set; }
    public int LocationId { get; set; }
    public Char Gender { get; set; }
    public DateTime DOB { get; set; }
    [MaxLength(45)]
    public string Occupation { get; set; }
    public string About { get; set; }
    public DateTime DateTime { get; set; }
    public User User { get; set; }
    public Location Location { get; set; }
}