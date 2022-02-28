using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ScandinavianFood.Models.DomainModels;
using System.Linq;

namespace ScandinavianFood.Models.Repositories
{
    //async repo
    public class PostRepository : IPostRepository
    {
        private readonly SiteDbContext context;

        public PostRepository(SiteDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ForumPost> ForumPosts
        {
            get
            {
                //query to get all posts and include replies
                return context.ForumPosts.Include(p => p.Poster)
                    .Include(p => p.ForumReplies)
                    .ThenInclude(p => p.Replier)
                    .Include(p => p.ForumRatings)
                    .ThenInclude(p => p.Rater);
            }
        }

        public async Task<ForumPost> GetById(int id)
        {
            return await context.ForumPosts.FindAsync(id);
        }

        public async Task Insert(ForumPost post)
        {
            await context.ForumPosts.AddAsync(post);
        }

        public async Task Delete(int id)
        {
            ForumPost post = await context.ForumPosts.FindAsync(id);
            context.ForumPosts.Remove(post);
        }

        public async Task Update(ForumPost post)
        {
            context.Update(post);
            await context.SaveChangesAsync();
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
    }
}
