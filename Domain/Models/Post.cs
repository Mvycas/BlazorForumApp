namespace Domain.Models;

public class Post
{
    public string Header { get; set; }
    public string Body { get; set; }
    public User Author { get; set; }
    
    public Post()
    {
     
        Header=String.Empty;
        Body=String.Empty;
        Author = new User();
  
    }
}