using Domain.Dtos.PostCategories;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class PostCategoryService
{
    private readonly DataContext _context;

    public PostCategoryService(DataContext context)
    {
        _context = context;
    }

    public PostCategoryBase AddPostCategory(PostCategoryBase postCategory)
    {
        var postcategory = new PostCategory()
        {
            Id = postCategory.Id,
            PostId = postCategory.PostId,
            CategoryId = postCategory.CategoryId,
        };
        _context.SaveChanges();
        return postCategory;
    }
    

    public PostCategory UpdatePostCategory(PostCategory postCategory)
    {
        var find = _context.PostCategoryess.Find(postCategory.Id);
        if (find != null)
        {
            find.Id = postCategory.Id;
            find.PostId = postCategory.PostId;
            find.CategoryId = postCategory.CategoryId;

            _context.SaveChanges();
        }
        return postCategory;
    }

    public bool DeletePostCategory(int id)
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

    public PostCategory GetPostCategoryById(int id)
        {
            var find = _context.PostCategoryess.Find(id);
            if (find == null) return new PostCategory();
            return new PostCategory()
            {
                Id = find.Id,
                PostId = find.PostId ,
                CategoryId = find.CategoryId , 
            };    
        }

    

    public List<PostCategoryBase> PostCategories()
    {
        return _context.PostCategoryess.Select(c => new PostCategoryBase()
        {
            Id = c.Id,
            PostId = c.PostId,
            CategoryId = c.CategoryId,
           
        }).ToList();
    }
}