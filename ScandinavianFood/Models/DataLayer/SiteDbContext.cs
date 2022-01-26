using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ScandinavianFood.Models
{
    public class SiteDbContext : IdentityDbContext<User>
    {
        public SiteDbContext(DbContextOptions<SiteDbContext> options) : base(options)
        { }
        public DbSet<ForumPost> ForumPosts { get; set; }
    }
}
