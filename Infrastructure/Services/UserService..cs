
using Domain.Dtos.Users;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class UserService
{
    private readonly DataContext _context;

    public UserService(DataContext context)
    {
        _context = context;
    }

    public UserBase AddUser(UserBase tag)
    {
        _context.Users.Add(new User()
        {
            Id=tag.Id,
            UserName = tag.UserName, 
            Email = tag.Email, 
            Password = tag.Password, 
            PasswordSalt = tag.PasswordSalt, 
            DateRegistered = tag.DateRegistered, 
            UserType = tag.UserType, 
            AccountStatus = tag.AccountStatus,
        });
        _context.SaveChanges();
        return tag;
    }
    

    public User UpdateUser(User tag)
    {
        var find = _context.Users.Find(tag.Id);
        if (find != null)
        {
            find.Id = tag.Id;
            find.UserName = tag.UserName;
            find.Email = tag.Email; 
            find.Password = tag.Password; 
            find.PasswordSalt = tag.PasswordSalt; 
            find.DateRegistered = tag.DateRegistered; 
            find.UserType = tag.UserType; 
            find.AccountStatus = tag.AccountStatus;
            

            _context.SaveChanges();
        }
        return tag;
    }

    public bool DeleteUser(int id)
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

    public User GetUserById(int id)
        {
            var find = _context.Users.Find(id);
            if (find == null) return new User();
            return new User()
            {
                Id = find.Id,
                UserName=find.UserName,
                Email = find.Email, 
                Password = find.Password, 
                PasswordSalt = find.PasswordSalt, 
                DateRegistered = find.DateRegistered, 
                UserType = find.UserType, 
                AccountStatus = find.AccountStatus,
            };    
        }

    

    public List<UserBase> Users()
    {
        return _context.Users.Select(c => new UserBase()
        {
            Id = c.Id,
            UserName=c.UserName,
            Email = c.Email, 
            Password = c.Password, 
            PasswordSalt = c.PasswordSalt, 
            DateRegistered = c.DateRegistered, 
            UserType = c.UserType, 
            AccountStatus = c.AccountStatus,

        }).ToList();
    }
}