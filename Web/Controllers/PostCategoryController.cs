
using Domain.Dtos.PostCategories;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PostCategoryController :ControllerBase
{
    private readonly PostCategoryService _postCategoryService;

    public PostCategoryController(PostCategoryService postCategoryService)
    {
        _postCategoryService = postCategoryService;
    }
    
    [HttpGet("GetPostCategoryById")]
    public PostCategory GetPostCategoryById(int id)
    {
        return  _postCategoryService.GetPostCategoryById(id);
    }
    
    [HttpPost("AddPostCategory")]
    public AddPostCategory AddPostCategory(PostCategoryBase postcategory) 
    {
        return _postCategoryService.AddPostCategory(postcategory) as AddPostCategory;
    }
    
    [HttpPut("UpdatePostCategory")]
    public PostCategory UpdatePostCategory(PostCategory postcategory)
    {
        return _postCategoryService.UpdatePostCategory(postcategory);
    }
    
    [HttpDelete("DeletePostcategory")]
    public bool DeletePostCategory(int id)
    {
        return _postCategoryService.DeletePostCategory(id);
    }
    
    
}