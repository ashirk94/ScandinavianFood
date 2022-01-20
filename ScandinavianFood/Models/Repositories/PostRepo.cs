using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ScandinavianFood.Models.Repositories
{
    public class PostRepository : IRepository<ForumPostModel>
    {
        private readonly ForumPostContext context;

        public PostRepository(ForumPostContext context)
        {
            this.context = context;
        }

        public IEnumerable<ForumPostModel> GetAll()
        {
            return context.ForumPosts;
        }

        public ForumPostModel GetById(int id)
        {
            return context.ForumPosts.Find(id);
        }

        public void Insert(ForumPostModel post)
        {
            context.ForumPosts.Add(post);
        }

        public void Delete(int id)
        {
            ForumPostModel post = context.ForumPosts.Find(id);
            context.ForumPosts.Remove(post);
        }

        public void Update(ForumPostModel post)
        {
            context.Entry(post).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
