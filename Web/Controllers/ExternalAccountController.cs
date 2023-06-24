using Domain.Dtos.ExternalAccounts;
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

   
    [HttpGet("GetExternalAccountbyId")]
    public ExternalAccount GetExternalAccountById(int id)
    {
        return _service.GetExternalAccountByUserId(id);
    }
    
    [HttpPost("AddExternalAccount")]
    public ExternalAccountBase AddPublisher(ExternalAccountBase externalAccount)
    {
        return _service.AddExternalAccount(externalAccount);
    }

    [HttpPut("UpdateExternalAccount")]
    public ExternalAccount UpdateExternalAccount(ExternalAccount externalAccount)
    {
        return _service.UpdateExternalAccount(externalAccount);
    }
    
    [HttpDelete("DeleteExternalAccount")]
    public bool DeleteExternalAccount(int id)
    {
        return _service.DeleteExternalAccount(id);
    }
    
    
}