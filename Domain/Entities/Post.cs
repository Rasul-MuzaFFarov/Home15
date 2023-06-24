using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Post
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    [MaxLength(45)]
    public string Title { get; set; }
    public string Content { get; set; }
    [MaxLength(45)]
    public string Status { get; set; }
    public DateTime DatePublished { get; set; }
    public User User { get; set; }
    public List<PostTag> PostTags { get; set; }
    public List<PostCategory> PostCategories { get; set; }
    public List<PostComment> PostComments { get; set; }
    public List<PostFavorite> PostFavorites { get; set; } 
    public List<PostStat> PostStats { get; set; }
}