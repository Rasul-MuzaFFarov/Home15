using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.ExternalAccounts;

public class ExternalAccountBase
{
    
    public int UserId { get; set; }
    public string FacebookEmail { get; set; }
    public string TwitterUserName { get; set; }
}