
using Domain.Dtos.Tags;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class TagService
{
    private readonly DataContext _context;

    public TagService(DataContext context)
    {
        _context = context;
    }

    public TagBase AddTag(TagBase tag)
    {
        _context.Tags.Add(new Tag()
        {
            Id=tag.Id,
            TagName = tag.TagName, 
            

        });
        _context.SaveChanges();
        return tag;
    }
    

    public TagBase UpdateTag(TagBase tag)
    {
        var find = _context.Tags.Find(tag.Id);
        if (find != null)
        {
            find.Id = tag.Id;
            find.TagName = tag.TagName;
            

            _context.SaveChanges();
        }
        return tag;
    }

    public bool DeleteTag(int id)
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

    public TagBase GetTagById(int id)
        {
            var find = _context.Tags.Find(id);
            if (find == null) return new TagBase();
            return new TagBase()
            {
                Id = find.Id,
                TagName=find.TagName,
            };    
        }

    

    public List<TagBase> Tags()
    {
        return _context.Tags.Select(c => new TagBase()
        {
            Id = c.Id,
            TagName=c.TagName,

        }).ToList();
    }

    
}