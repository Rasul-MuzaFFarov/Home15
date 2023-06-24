
using Domain.Dtos.Posts;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PostFavoriteController :ControllerBase
{
    private readonly PostService _postService;

    public PostFavoriteController(PostService postService)
    {
        _postService = postService;
    }

    
    [HttpGet("GetPostById")]
    public  Post GetPostById(int id)
    {
        return  _postService.GetPostById(id);
    }
    
    [HttpPost("AddPost")]
    public AddPost AddPost(PostBase post) 
    {
        return (AddPost)_postService.AddPost(post);
    }
    
    [HttpPut("UpdatePost")]
    public Post UpdatePost(Post post)
    {
        return _postService.UpdatePost(post);
    }
    
    [HttpDelete("DeletePost")]
    public bool DeletePost(int id)
    {
        return _postService.DeletePost(id);
    }
    
    
}