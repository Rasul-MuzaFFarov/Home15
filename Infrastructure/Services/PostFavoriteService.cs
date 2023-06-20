
using Domain.Dtos.PostFavorites;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class PostFavoriteService
{
    private readonly DataContext _context;

    public PostFavoriteService(DataContext context)
    {
        _context = context;
    }

    public PostFavoriteBase AddPostFavorite(PostFavoriteBase postFavorite)
    {
        _context.PostFavorites.Add(new PostFavorite()
        {
            Id = postFavorite.Id,
            PostId = postFavorite.PostId,
            UserId = postFavorite.UserId,
            DateFavorited=postFavorite.DateFavorited,

        });
        _context.SaveChanges();
        return postFavorite;
    }
    

    public PostFavoriteBase UpdatePostFavorite(PostFavoriteBase postFavorite)
    {
        var find = _context.PostFavorites.Find(postFavorite.Id);
        if (find != null)
        {
            find.Id = postFavorite.Id;
            find.PostId = postFavorite.PostId;
            find.UserId = postFavorite.UserId;
            find.DateFavorited = postFavorite.DateFavorited;
            _context.SaveChanges();
        }
        return postFavorite;
    }

    public bool DeletePostFavorite(int id)
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

    public PostFavoriteBase GetPostFavoriteById(int id)
        {
            var find = _context.PostFavorites.Find(id);
            if (find == null) return new PostFavoriteBase();
            return new PostFavoriteBase()
            {
                Id = find.Id,
                PostId = find.PostId ,
                UserId = find.UserId ,
                DateFavorited = find.DateFavorited,

                
            };    
        }

    

    public List<PostFavoriteBase> PostFavorites()
    {
        return _context.PostFavorites.Select(c => new PostFavoriteBase()
        {
            Id = c.Id,
            PostId = c.PostId,
            UserId = c.UserId,
            DateFavorited = c.DateFavorited,
        }).ToList();
    }
}