using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class User
{
    [Key]
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    
    public string SecurityLevel { get; set; }

    public User(string userName, string pass, string role, string securityLevel)
    {
        UserName = userName;
        Password = pass;
        Role = role;
        SecurityLevel = securityLevel;

    }
    public User(){ }
    
}