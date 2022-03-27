using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Post
{
    [Required,MaxLength(128)]
    public string Header { get; set; }
    
    [Required,MaxLength(5000)]
    public string Body { get; set; }
    public string Author { get; set; }
    
    public Post()
    {
     
        Header = string.Empty;
        Body = string.Empty;
        Author = string.Empty;
    }
}