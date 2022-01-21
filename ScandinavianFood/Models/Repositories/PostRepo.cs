using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ScandinavianFood.Models.Repositories
{
    public class PostRepo : IRepository<ForumPost>
    {
        private readonly SiteDbContext context;

        public PostRepo(SiteDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<ForumPost> GetAll()
        {
            return context.ForumPosts;
        }

        public ForumPost GetById(int id)
        {
            return context.ForumPosts.Find(id);
        }

        public void Insert(ForumPost post)
        {
            context.ForumPosts.Add(post);
        }

        public void Delete(int id)
        {
            ForumPost post = context.ForumPosts.Find(id);
            context.ForumPosts.Remove(post);
        }

        public void Update(ForumPost post)
        {
            context.Entry(post).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
