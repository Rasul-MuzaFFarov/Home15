namespace Domain.Dtos.FollowingRelationShips;

public class FollowingRelationShipBase
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int FollowingId { get; set; }
    public DateTime DateFollowed { get; set; }
}