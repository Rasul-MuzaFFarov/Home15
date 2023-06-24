using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Tag
{
    [Key]
    public int Id { get; set; }
    [MaxLength(45)]
    public string TagName { get; set; } 
    public List<PostTag> PostTags { get; set; } 
}