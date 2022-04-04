using Blazor.Pages;
using Domain.Contracts;
using Domain.Models;
using JsonDataAccess.Context;

namespace Blazor.DAO;

public class DataDAO : IUser, IPost 
{

    private JsonContext fileContext;

    public DataDAO(JsonContext jsonContext)
    {
        fileContext = jsonContext;
    }

    public async Task<ICollection<Post>> GetPosts()
    {
        return fileContext.Forum.Posts;
    }

    public Task<Post> GetPostById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Post> AddPost(Post post)
    {
        fileContext.Forum.Posts.Add(post);
        await fileContext.SaveChangesAsync();
        return post;
    }

    public Task DeletePost(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePost(Post post)
    {
        throw new NotImplementedException();
    }

    public async Task<User> AddUser(User user)
    {
        if (fileContext.Forum.Users.Any(t => t.UserName.Equals(user.UserName)))
        {
            throw new Exception("User is already registered!");
        }
        else
        {
            fileContext.Forum.Users.Add(user);
            await fileContext.SaveChangesAsync();
            return user;
        }
    }

    public async Task<User> GetUser(string username)
    {
        return fileContext.Forum.Users.First(t => t.UserName.Equals(username));
    }
}