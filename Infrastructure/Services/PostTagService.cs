
using Domain.Dtos.PostTags;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class PostTagService
{
    private readonly DataContext _context;

    public PostTagService(DataContext context)
    {
        _context = context;
    }

    public PostTagBase AddPostTag(PostTagBase postTag)
    {
        _context.PostTags.Add(new PostTag()
        {
            Id=postTag.Id,
            PostId = postTag.PostId, 
            TagId = postTag.TagId,
            

        });
        _context.SaveChanges();
        return postTag;
    }
    

    public PostTag UpdatePostTag(PostTag postTag)
    {
        var find = _context.PostTags.Find(postTag.Id);
        if (find != null)
        {
            find.Id = postTag.Id;
            find.PostId = postTag.PostId;
            find.TagId = postTag.TagId;
            

            _context.SaveChanges();
        }
        return postTag;
    }

    public bool DeletePostTag(int id)
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

    public PostTagBase GetPostTagById(int id)
        {
            var find = _context.PostTags.Find(id);
            if (find == null) return new PostTagBase();
            return new PostTagBase()
            {
                Id = find.Id,
                PostId=find.PostId,
                TagId=find.TagId,
            };    
        }

    

    public List<PostTagBase> PostTags()
    {
        return _context.PostTags.Select(c => new PostTagBase()
        {
            Id = c.Id,
            PostId=c.PostId,
            TagId=c.TagId,

        }).ToList();
    }
}