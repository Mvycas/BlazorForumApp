using Domain.Models;

namespace Domain.Contracts;

public interface IUser
{
    public void AddUser(string username, string password);
    public Task<User> GetUser(string username);
}