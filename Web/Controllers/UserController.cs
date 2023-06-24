
using Domain.Dtos.Users;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController :ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    
    [HttpGet("GetUserbyId")]
    public  User GetUserById(int id)
    {
        return  _userService.GetUserById(id);
    }
    
    [HttpPost("AddUser")]
    public AddUser AddUser(UserBase user) 
    {
        return (AddUser)_userService.AddUser(user);
    }
    
    [HttpPut("UpdateUser")]
    public User UpdateUser(User user) 
    {
        return _userService.UpdateUser(user);
    }
    
    [HttpDelete("DeleteUser")]
    public bool DeleteUser(int id)
    {
        return _userService.DeleteUser(id);
    }
    
    
}