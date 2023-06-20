namespace Domain.Dtos.PostComments;

public class PostCommentBase
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int CommenterId { get; set; }
    public string Comment { get; set; }
    public DateTime DateCommented { get; set; }
}