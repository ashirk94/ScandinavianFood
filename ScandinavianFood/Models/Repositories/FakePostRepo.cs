using System;
using Microsoft.EntityFrameworkCore;
using ScandinavianFood.Models.Repositories;
using System.Collections.Generic;

namespace ScandinavianFood.Models.Repositories
{
    public class FakePostRepo : IRepository<ForumPostModel>
    {
        private readonly List<ForumPostModel> posts = new List<ForumPostModel>();

        public IEnumerable<ForumPostModel> GetAll()
        {
            return posts;
        }

        public ForumPostModel GetById(int id)
        {
            ForumPostModel post = posts.Find(p => p.Id == id);
            return post;
        }

        public void Insert(ForumPostModel post)
        {
            post.Id = posts.Count;
            posts.Add(post);
        }

        public void Delete(int id)
        {
            ForumPostModel post = posts.Find(p => p.Id == id);
            posts.Remove(post);
        }

        public void Update(ForumPostModel post)
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
