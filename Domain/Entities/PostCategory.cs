using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class PostCategory
{
    [Key]
    public int Id { get; set; }
    public int PostId { get; set; }
    public int CategoryId { get; set; }
    public Post Post { get; set; }
    public Category Category { get; set; }
}