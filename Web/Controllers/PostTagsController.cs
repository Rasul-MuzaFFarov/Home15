
using Domain.Dtos.PostTags;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PostTagsController :ControllerBase
{
    private readonly PostTagService _postTagServices;

    public PostTagsController(PostTagService postTagService)
    {
        _postTagServices = postTagService;
    }

    
    [HttpGet("GetPostTagbyId")]
    public  PostTagBase GetPostTagById(int id)
    {
        return  _postTagServices.GetPostTagById(id);
    }
    
    [HttpPost("AddPostTag")]
    public AddPostTag AddPostTag(PostTagBase postTag) 
    {
        return (AddPostTag)_postTagServices.AddPostTag(postTag);
    }
    
    [HttpPut("UpdatePostTag")]
    public PostTag UpdatePostTag(PostTag postTag) 
    {
        return _postTagServices.UpdatePostTag(postTag);
    }
    
    [HttpDelete("DeletePostTag")]
    public bool DeletePostTag(int id)
    {
        return _postTagServices.DeletePostTag(id);
    }
    
    
}