using Domain.Contracts;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]

public class ForumController : ControllerBase
{
    private IPost _ipost;

    public ForumController(IPost postService)
    {
        _ipost = postService;
    }
    
    [HttpGet]
    public async Task<ActionResult<ICollection<Post>>> GetAll()
    {
        try
        {
            ICollection<Post> posts = await _ipost.GetPosts();
            return Ok(posts);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<Post>> AddPost([FromBody] Post post)
    {
        try
        {    
            Post added = await _ipost.AddPost(post);
            return Created($"/posts/{added.Header}", added);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
}