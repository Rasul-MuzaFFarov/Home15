
using Domain.Dtos.PostComments;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PostCommentController :ControllerBase
{
    private readonly PostCommentService _postCommentService;

    public PostCommentController(PostCommentService postCommentService)
    {
        _postCommentService = postCommentService;
    }

    
    [HttpGet("GetPostCommentById")]
    public PostCommentBase GetPostCommentById(int id)
    {
        return  _postCommentService.GetPostCommentById(id);
    }
    
    [HttpPost("AddPostComment")]
    public AddPostComment AddPostComment(PostCommentBase postComment) 
    {
        return (AddPostComment)_postCommentService.AddPostComment(postComment);
    }
    
    [HttpPut("UpdatePostComment")]
    public PostCommentBase UpdatePostComment(PostCommentBase postComment)
    {
        return _postCommentService.UpdatePostComment(postComment);
    }
    
    [HttpDelete("DeletePostComment")]
    public bool DeletePostComment(int id)
    {
        return _postCommentService.DeletePostComment(id);
    }
    
    
}