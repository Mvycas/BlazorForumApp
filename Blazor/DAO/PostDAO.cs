using Blazor.Pages;
using Domain.Contracts;
using Domain.Models;
using JsonDataAccess.Context;

namespace Blazor.DAO;

public class PostDAO : IPost
{

    private JsonContext fileContext;

    public PostDAO(JsonContext jsonContext)
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
}