using Domain.Models;

namespace Domain.Contracts;

public interface IPost
{
    public Task<ICollection<Post>> GetPosts();
    public Task<Post> GetPostById(int id);
    public Task<Post> AddPost(Post post);
    public Task DeletePost(int id);
    public Task UpdatePost(Post post);
}