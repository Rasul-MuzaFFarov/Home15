namespace Domain.Entities;

public class PostStat
{
    public int PostId { get; set; }
    public int ViewCount { get; set; }
    public Post Post { get; set; }
}