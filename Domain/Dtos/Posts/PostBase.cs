namespace Domain.Dtos.Posts;

public class PostBase
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Status { get; set; }
    public DateTime DatePublished { get; set; }
}