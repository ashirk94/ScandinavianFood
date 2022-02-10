using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScandinavianFood.Models.DataLayer;
using System.Threading.Tasks;

namespace ScandinavianFood.Models
{
    public class SiteDbContext : IdentityDbContext<AppUser>
    {
        public SiteDbContext() { }
        public SiteDbContext(DbContextOptions<SiteDbContext> options) : base(options)
        { }
        public DbSet<ForumPost> ForumPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeds users and posts
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
