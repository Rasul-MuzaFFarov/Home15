using System.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<ExternalAccount> ExternalAccounts { get; set; }
    public DbSet<FollowingRelationShip> FollowingRelationShips { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostCategory> PostCategoryess { get; set; }
    public DbSet<PostComment> PostComments { get; set; }
    public DbSet<PostFavorite> PostFavorites { get; set; }
    public DbSet<PostStat> PostStats { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<UserSetting> UserSettings { get; set; }


    
}