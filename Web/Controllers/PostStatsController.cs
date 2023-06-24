
using Domain.Dtos.PostStats;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PostStatController :ControllerBase
{
    private readonly PostStatService _postStatServices;

    public PostStatController(PostStatService postStatService)
    {
        _postStatServices = postStatService;
    }

    
    [HttpGet("GetPostStatById")]
    public  PostStat GetPostStatById(int id)
    {
        return  _postStatServices.GetPostStatById(id);
    }
    
    [HttpPost("AddPostStat")]
    public AddPostStat AddPostStat(PostStatBase postStat) 
    {
        return (AddPostStat)_postStatServices.AddPostStat(postStat);
    }
    
    [HttpPut("UpdatePostStat")]
    public PostStat UpdatePostStat(PostStat postStat) 
    {
        return _postStatServices.UpdatePostStat(postStat);
    }
    
    [HttpDelete("DeletePostStat")]
    public bool DeletePost(int id)
    {
        return _postStatServices.DeletePostStat(id);
    }
    
    
}