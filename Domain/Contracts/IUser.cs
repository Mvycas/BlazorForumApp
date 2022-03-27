using Domain.Models;

namespace Domain.Contracts;

public interface IUser
{
    public Task<User> AddUser(User user);
    public Task<User> GetUser(string username);
}