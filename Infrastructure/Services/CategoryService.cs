using Domain.Dtos.Categories;
using Domain.Dtos.Categories;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class CategoryService
{
    private readonly DataContext _context;

    public CategoryService(DataContext context)
    {
        _context = context;
    }

    public CategoryBase AddCategory(CategoryBase category)
    {
        _context.Categories.Add(new Category()
        {
            Id = category.Id,
            CategoryName = category.CategoryName
        });
        _context.SaveChanges();
        return category;
    }
    

    public Category UpdateCategory(Category category)
    {
        var find = _context.Categories.Find(category.Id);
        if (find != null)
        {
            find.Id = category.Id;
            find.CategoryName = category.CategoryName;
            _context.SaveChanges();
        }
        return category;
    }

    public bool DeleteCategory(int id)
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

    public Category GetCategoryById(int id)
    {
        var find = _context.Categories.Find(id);
        if (find == null) return new Category();
        return new Category()
        {
            Id = find.Id,
            CategoryName = find.CategoryName
        };    

    }

    public List<CategoryBase> GetListOfCategories()
    {
        return _context.Categories.Select(c => new CategoryBase()
        {
            Id = c.Id,
            CategoryName = c.CategoryName
        }).ToList();
    }


    
}