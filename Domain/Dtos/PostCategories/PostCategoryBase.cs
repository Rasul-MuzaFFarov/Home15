namespace Domain.Dtos.PostCategories;

public class PostCategoryBase
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int CategoryId { get; set; }
}