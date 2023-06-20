using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExternalAccountController : ControllerBase
{
    private readonly ExternalAccountService _service;

    public ExternalAccountController(ExternalAccountService service)
    {
        _service = service;
    }

    [HttpGet("GetExternalAccount")]
    public List<ExternalAccount> GetExternalAccounts()
    {
        return _service.ExternalAccounts();
    }
    
    [HttpGet("GetExternalAccountbyId")]
    public ExternalAccount GetExternalAccountById(int id)
    {
        return _service.GetExternalAccountByUserId(id);
    }
    
    [HttpPost("AddExternalAccount")]
    public ExternalAccount AddPublisher(ExternalAccount externalAccount)
    {
        return _service.AddExternalAccount(externalAccount);
    }

    [HttpPut("UpdatePublisher")]
    public Publisher UpdatePublisher(Publisher publisher)
    {
        return _service.UpdatePublisher(publisher);
    }
    
    [HttpDelete("DeletePublisher")]
    public bool DeletePublisher(int id)
    {
        return _service.DeletePublisher(id);
    }
    
    
}