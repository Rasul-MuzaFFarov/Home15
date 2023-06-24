
using Domain.Dtos.Posts;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class PostService
{
    private readonly DataContext _context;

    public PostService(DataContext context)
    {
        _context = context;
    }

    public PostBase AddPost(PostBase post)
    {
        _context.Posts.Add(new Post()
        {
            Id = post.Id,
            Title = post.Title,
            UserId = post.UserId,
            Content=post.Content,
            Status=post.Status,
            DatePublished=post.DatePublished,
            

        });
        _context.SaveChanges();
        return post;
    }
    

    public Post UpdatePost(Post post)
    {
        var find = _context.Posts.Find(post.Id);
        if (find != null)
        {
            find.Id = post.Id;
            find.Title = post.Title;
            find.UserId = post.UserId;
            find.Content = post.Content;
            find.Status = post.Status;
            find.DatePublished = post.DatePublished;
            

            _context.SaveChanges();
        }
        return post;
    }

    public bool DeletePost(int id)
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

    public Post GetPostById(int id)
        {
            var find = _context.Posts.Find(id);
            if (find == null) return new Post();
            return new Post()
            {
                Id = find.Id,
                Title = find.Title ,
                UserId = find.UserId ,
                Content = find.Content,
                Status = find.Status,
                DatePublished=find.DatePublished,
            };    
        }

    

    public List<PostBase> Posts()
    {
        return _context.Posts.Select(c => new PostBase()
        {
            Id = c.Id,
            Title = c.Title,
            UserId = c.UserId,
            Content = c.Content,
            Status = c.Status,
            DatePublished=c.DatePublished,

        }).ToList();
    }
}