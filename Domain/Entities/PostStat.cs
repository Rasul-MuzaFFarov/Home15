using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class PostStat
{
    [Key]
    public int PostId { get; set; }
    public int ViewCount { get; set; }
    public Post Post { get; set; }
}