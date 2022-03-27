using System.Text.Json;
using Domain.Models;

namespace JsonDataAccess.Context;

public class JsonContext
{
    private string forumPath = "forum.json";

    private Post? forum;
    public Post Forum
    {
        get
        {
            if (forum == null)
            {
                LoadData();
            }

            return forum!;
        }
        private set{}
    }

    public JsonContext()
    {
        if (File.Exists(forumPath))
        {
            LoadData();
        }
        else
        {
            CreateFile();
        }
    }

    private void CreateFile()
    {
        forum = new Post();
        Task.FromResult(SaveChangesAsync());
    }

    private void LoadData()
    {
        string forumAsJson = File.ReadAllText(forumPath);
        forum = JsonSerializer.Deserialize<Post>(forumAsJson)!;
    }

    public async Task SaveChangesAsync()
    {
        string forumAsJson = JsonSerializer.Serialize(forum, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = false
        });
        await File.WriteAllTextAsync(forumPath,forumAsJson);
        forum = null;
	}
}