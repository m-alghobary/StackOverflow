using Microsoft.EntityFrameworkCore;
using StackOverflow.Data.Models;

namespace StackOverflow.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> context) : base(context) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<PostType> PostTypes { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<VoteType> VoteTypes { get; set; }
    public DbSet<Vote> Votes { get; set; }
    public DbSet<LinkType> LinkTypes { get; set; }
    public DbSet<PostLink> PostLinks { get; set; }
}
