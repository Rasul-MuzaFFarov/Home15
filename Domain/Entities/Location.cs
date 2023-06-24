using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Location
{
    [Key]
    public int Id { get; set; }
    [MaxLength(45)]
    public string City { get; set; }
    [MaxLength(45)]
    public string State { get; set; }
    [MaxLength(45)]
    public string ZipCode { get; set; }
    [MaxLength(45)]
    public string Country { get; set; }
    public List<UserProfile> UsersProfiles { get; set; }
}