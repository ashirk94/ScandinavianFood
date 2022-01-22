using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ScandinavianFood.Models
{
    public class SiteDbContext : IdentityDbContext<User>
    {
        public SiteDbContext() : base()
        { }
        public SiteDbContext(DbContextOptions<SiteDbContext> options) : base(options)
        { }
        public DbSet<ForumPost> ForumPosts { get; set; }
    }
}
