namespace Domain.Entities;

public class FollowingRelationShip
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int FollowingId { get; set; }
    public DateTime DateFollowed { get; set; }
    public User User { get; set; }
    public User Following { get; set; }
}