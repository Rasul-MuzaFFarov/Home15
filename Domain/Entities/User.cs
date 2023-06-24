using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    [MaxLength(45)]
    public string UserName { get; set; }
    [MaxLength(45)] 
    public string Email { get; set; }
    [MaxLength(45)]
    public string Password { get; set; }
    [MaxLength(45)]
    public string PasswordSalt { get; set; }
    public DateTime DateRegistered { get; set; }
    [MaxLength(45)]
    public string UserType { get; set; }
    [MaxLength(45)]
    public string AccountStatus { get; set; }
    public List<Post> Posts { get; set; }
    public List<PostComment> PostComments { get; set; }
    public List<PostFavorite> PostFavorites { get; set; }
    public List<ExternalAccount> ExternalAccounts { get; set; }
    public List<UserSetting> UserSettings { get; set; }
    public List<UserProfile> UserProfiles { get; set; }
}