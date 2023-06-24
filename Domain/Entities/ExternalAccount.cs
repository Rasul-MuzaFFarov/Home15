using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class ExternalAccount
{
    [Key]
    public int UserId { get; set; }
    [MaxLength(45)]
    public string FacebookEmail { get; set; }
    [MaxLength(45)]
    public string TwitterUserName { get; set; }
    public User User { get; set; }
}