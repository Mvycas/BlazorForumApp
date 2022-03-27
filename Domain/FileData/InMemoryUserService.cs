﻿
using Domain.Contracts;
using Domain.Models;

namespace Domain.FileData;

public class InMemoryUserService : IUser
{
    public void AddUser(string username, string password)
    {
        User user = new User(username, password, "New User", "2");
        users.Add(user);
    }
    public async Task<User?> GetUser(string username)
    {
        User? find = users.Find(user => user.UserName.Equals(username));
        return find;
    }

    private List<User> users = new()
    {
        new User("Marty", "Party", "Student", "2"),
        new User("Bozhe", "Moj", "Student", "3"),
        new User("DreadPirate", "Roberts", "HeadOfDepartment", "1")        
    };
}