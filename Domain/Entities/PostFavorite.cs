using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class PostFavorite
{
    [Key]
    public int Id { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }
    public DateTime DateFavorited { get; set; }
    public Post Post { get; set; }
    public User User { get; set; }
}