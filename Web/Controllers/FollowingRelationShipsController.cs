using Domain.Dtos.FollowingRelationShips;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FollowingReletionShipsController :ControllerBase
{
    private readonly FollowingRelationShipService _followingRelation;

    public FollowingReletionShipsController(FollowingRelationShipService followService)
    {
        _followingRelation = followService;
    }

    
    
    
    [HttpPost("AddFollowingReletionalShip")]
    public AddFollowingRelationShip AddPostAddFollowingRelationShip(FollowingRelationShipBase followingRelationShipBase) 
    {
        return (AddFollowingRelationShip)_followingRelation.AddFollowingRelationShip(followingRelationShipBase);
    }
    
    [HttpPut("UpdateFollowingReletionalShips")]
    public FollowingRelationShipBase UpdateFollowingRelationShip(FollowingRelationShipBase followingRelationShipBase)
    {
        return _followingRelation.UpdateFollowingRelationShip(followingRelationShipBase);
    }
    
    [HttpDelete("DeletefollowingReletionalShips")]
    public bool DeleteFollowingReletionalShips(int id)
    {
        return _followingRelation.DeleteFollowingRelationShip(id);
    }
    
    
}