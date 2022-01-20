using Microsoft.EntityFrameworkCore;

namespace ScandinavianFood.Models
{
    public class ForumPostContext : DbContext
    {
        public ForumPostContext()
        { }
        public ForumPostContext(DbContextOptions<ForumPostContext> options) : base(options)
        { }
        public DbSet<ForumPostModel> ForumPosts { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
