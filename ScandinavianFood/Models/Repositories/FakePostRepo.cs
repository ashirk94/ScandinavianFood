using System.Collections.Generic;

namespace ScandinavianFood.Models.Repositories
{
    public class FakePostRepo : IRepository<ForumPost>
    {
        private readonly List<ForumPost> posts = new List<ForumPost>();

        public IEnumerable<ForumPost> GetAll()
        {
            return posts;
        }

        public ForumPost GetById(int id)
        {
            ForumPost post = posts.Find(p => p.Id == id);
            return post;
        }

        public void Insert(ForumPost post)
        {
            post.Id = posts.Count;
            posts.Add(post);
        }

        public void Delete(int id)
        {
            ForumPost post = posts.Find(p => p.Id == id);
            posts.Remove(post);
        }

        public void Update(ForumPost post)
        {
            int id = post.Id;
            post = posts.Find(p => p.Id == id);
        }

        public void Save()
        {
            return;
        }
    }
}
