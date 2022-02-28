using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ScandinavianFood.Models.DomainModels;
using System.Linq;

namespace ScandinavianFood.Models.Repositories
{
    public class FakePostRepo : IPostRepository
    {
        List<ForumPost> posts = new List<ForumPost>();

        public IQueryable<ForumPost> ForumPosts
        {
            get { return posts.AsQueryable<ForumPost>(); }
        }

        public async Task<ForumPost> GetById(int id)
        {
            return await Task.Run(() => posts[id]);
        }

        public async Task Insert(ForumPost post)
        {
            await Task.Run(() => posts.Add(post));
        }

        public async Task Delete(int id)
        {
            ForumPost post = await Task.Run(() => posts[id]);
            posts.Remove(post);
        }

        public async Task Update(ForumPost post)
        {
            ForumPost myPost = await Task.Run(() => posts[post.ForumPostId]);
            await Task.Run(() => myPost = post);
        }

        public async Task Save()
        {
            await Task.Run(() => Console.WriteLine("Saved"));
        }
    }
}
