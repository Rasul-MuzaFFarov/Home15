using System.Security.AccessControl;

namespace Domain.Entities;

public class PostComment
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int CommenterId { get; set; }
    public string Comment { get; set; }
    public DateTime DateCommented { get; set; }
    public Post Post { get; set; }
    public User Commenter { get; set; }
}