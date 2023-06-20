
using Domain.Dtos.FollowingRelationShips;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class FollowingRelationShipService
{
    private readonly DataContext _context;

    public FollowingRelationShipService(DataContext context)
    {
        _context = context;
    }

    public FollowingRelationShipBase AddFollowingRelationShip(FollowingRelationShipBase followingRelationShip)
    {
        _context.FollowingRelationShips.Add(new FollowingRelationShip()
        {
            Id = followingRelationShip.Id,
            UserId = followingRelationShip.UserId,
            FollowingId = followingRelationShip.FollowingId,
            DateFollowed= followingRelationShip.DateFollowed

        });
        _context.SaveChanges();
        return followingRelationShip;
    }
    

    public FollowingRelationShipBase UpdateFollowingRelationShip(FollowingRelationShipBase followingRelationShip)
    {
        var find = _context.FollowingRelationShips.Find(followingRelationShip.Id);
        if (find != null)
        {
            find.Id = followingRelationShip.Id;
            find.UserId = followingRelationShip.UserId;
            find.FollowingId = followingRelationShip.FollowingId;
            find.DateFollowed = followingRelationShip.DateFollowed;
            _context.SaveChanges();
        }
        return followingRelationShip;
    }

    public bool DeleteFollowingRelationShip(int id)
    {
        var find = _context.Categories.Find(id);
        if (find != null)
        {
            _context.Categories.Remove(find);
            _context.SaveChanges();
            return true;
        }

        return false;
    }

    public FollowingRelationShipBase GetFollowingRelationShipById(int id)
        {
            var find = _context.FollowingRelationShips.Find(id);
            if (find == null) return new FollowingRelationShipBase();
            return new FollowingRelationShipBase()
            {
                Id = find.Id,
                UserId = find.UserId ,
                FollowingId = find.FollowingId ,
                DateFollowed = find.DateFollowed  
            };    
        }

    

    public List<FollowingRelationShipBase> FollowingRelationShips()
    {
        return _context.FollowingRelationShips.Select(c => new FollowingRelationShipBase()
        {
            Id = c.Id,
            UserId = c.UserId,
            FollowingId = c.FollowingId,
            DateFollowed = c.DateFollowed
        }).ToList();
    }
}