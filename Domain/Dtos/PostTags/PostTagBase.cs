namespace Domain.Dtos.PostTags;

public class PostTagBase
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int TagId { get; set; }
}