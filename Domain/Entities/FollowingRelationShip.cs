using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class FollowingRelationShip
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public int FollowingId { get; set; }
    public DateTime DateFollowed { get; set; }
    [ForeignKey("UserId+")]
    public User User { get; set; }
    [ForeignKey("FollowingId")]
    public User Following { get; set; }
}