using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Category
{
    public int Id { get; set; }
    [MaxLength(45)]
    public string CategoryName { get; set; }

    public List<PostCategory> PostCategories { get; set; }
}