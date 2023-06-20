
using Domain.Dtos.PostStats;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class PostStatService
{
    private readonly DataContext _context;

    public PostStatService(DataContext context)
    {
        _context = context;
    }

    public PostStatBase AddPostStat(PostStatBase postStat)
    {
        _context.PostStats.Add(new PostStat()
        {
            PostId = postStat.PostId, 
            ViewCount=postStat.ViewCount,
            

        });
        _context.SaveChanges();
        return postStat;
    }
    

    public PostStatBase UpdatePostStat(PostStatBase postStat)
    {
        var find = _context.PostStats.Find(postStat.PostId);
        if (find != null)
        {
            
            find.ViewCount = postStat.ViewCount;
            

            _context.SaveChanges();
        }
        return postStat;
    }

    public bool DeletePostStat(int id)
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

    public PostStatBase GetPostStatById(int id)
        {
            var find = _context.PostStats.Find(id);
            if (find == null) return new PostStatBase();
            return new PostStatBase()
            {
                PostId = find.PostId,
                ViewCount=find.ViewCount,
            };    
        }

    

    public List<PostStatBase> PostStats()
    {
        return _context.PostStats.Select(c => new PostStatBase()
        {
            PostId = c.PostId,
            ViewCount=c.ViewCount,

        }).ToList();
    }
}