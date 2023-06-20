namespace Domain.Dtos.PostFavorites;

public class PostFavoriteBase
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }
    public DateTime DateFavorited { get; set; }
}