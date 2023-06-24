
using Domain.Dtos.ExternalAccounts;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class ExternalAccountService
{
    private readonly DataContext _context;

    public ExternalAccountService(DataContext context)
    {
        _context = context;
    }

    public ExternalAccountBase AddExternalAccount(ExternalAccountBase externalAccount)
    {
        _context.ExternalAccounts.Add(new ExternalAccount()
        {
            UserId = externalAccount.UserId,
            FacebookEmail = externalAccount.FacebookEmail,
            TwitterUserName = externalAccount.TwitterUserName,

        });
        _context.SaveChanges();
        return externalAccount;
    }
    

    public ExternalAccount UpdateExternalAccount(ExternalAccount externalAccount)
    {
        var find = _context.ExternalAccounts.Find(externalAccount.UserId);
        if (find != null)
        {
            find.UserId = externalAccount.UserId;
            find.FacebookEmail = externalAccount.FacebookEmail;
            find.TwitterUserName = externalAccount.TwitterUserName;
            _context.SaveChanges();
        }
        return externalAccount;
    }

    public bool DeleteExternalAccount(int id)
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

    public ExternalAccount GetExternalAccountByUserId(int id)
        {
            var find = _context.ExternalAccounts.Find(id);
            if (find == null) return new ExternalAccount();
            return new ExternalAccount()
            {
                UserId = find.UserId,
                FacebookEmail = find.FacebookEmail,
                TwitterUserName = find.TwitterUserName
            };
        }



        // public List<ExternalAccount> ExternalAccounts()
        // {
        //     return _context.ExternalAccounts.Select(c => new ExternalAccountBase()
        //     {
        //         UserId = c.UserId,
        //         FacebookEmail = c.FacebookEmail,
        //         TwitterUserName = c.TwitterUserName
        //     }).ToList();
        // }
    
}