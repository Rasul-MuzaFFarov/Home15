using Domain.Dtos.Categories;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly CategoryService _service;

    public CategoryController(CategoryService service)
    {
        _service = service;
    }

    
    [HttpGet("GetCategoryById")]
    public Category GetCategoryById(int id)
    {
        return _service.GetCategoryById(id);
    }
    
    [HttpPost("AddCategory")]
    public AddCategory AddCategory(AddCategory category)
    {
        return (AddCategory)_service.AddCategory(category);
    }

    [HttpPut("UpdateCategory")]
    public Category UpdateCategory(Category category)
    {
        return _service.UpdateCategory(category);
    }
    
    [HttpDelete("DeleteCategory")]
    public bool DeleteCategory(int id)
    {
        return _service.DeleteCategory(id);
    }
    
    
}