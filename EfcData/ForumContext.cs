using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EfcData;

public class ForumContext : DbContext
{
    
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Forum.db");
    }
}