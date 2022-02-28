using Microsoft.AspNetCore.Mvc;
using ScandinavianFood.Controllers;
using ScandinavianFood.Models.DomainModels;
using ScandinavianFood.Models.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class PostTests
    {
        [Fact]
        public async Task AddPostTestAsync()
        {
            var fakePostRepo = new FakePostRepo();
            var controller = new ForumController(null, fakePostRepo);

            //example posts
            var post1 = new ForumPost()
            {
                Text = "hello",
                ForumPostId = 1
            };
            var post2 = new ForumPost()
            {
                Text = "world",
                ForumPostId = 2
            };
            //add to repo
            await fakePostRepo.Insert(post1);
            await fakePostRepo.Insert(post2);

            //actions
            var viewResult = (ViewResult)await controller.Index();

            //assert tests
            var posts = (List<ForumPost>)viewResult.ViewData.Model;
            Assert.Equal(2, posts.Count);
            Assert.Equal(posts[0].Text, post1.Text);
            Assert.Equal(posts[1].Text, post2.Text);
        }
    }
}
