using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScandinavianFood.Models.DataLayer;
using ScandinavianFood.Models.DomainModels;

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

        public DbSet<ScandinavianFood.Models.DomainModels.ForumReply> ForumReply { get; set; }

        public DbSet<ScandinavianFood.Models.DomainModels.ForumRating> ForumRating { get; set; }
    }
}
