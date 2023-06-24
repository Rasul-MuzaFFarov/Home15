
using Domain.Dtos.Tags;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TagsController :ControllerBase
{
    private readonly TagService _tagService;

    public TagsController(TagService tagService)
    {
        _tagService = tagService;
    }

    
    [HttpGet("GetTagsById")]
    public  TagBase GetTagbyId(int id)
    {
        return  _tagService.GetTagById(id);
    }
    
    [HttpPost("Addtag")]
    public AddTag AddTag(TagBase tag) 
    {
        return (AddTag)_tagService.AddTag(tag);
    }
    
    [HttpPut("UpdateTag")]
    public TagBase UpdateTag(TagBase tag) 
    {
        return _tagService.UpdateTag(tag);
    }
    
    [HttpDelete("DeleteTag")]
    public bool DeleteTag(int id)
    {
        return _tagService.DeleteTag(id);
    }
    
    
}