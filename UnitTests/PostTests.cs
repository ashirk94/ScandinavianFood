﻿using Microsoft.AspNetCore.Mvc;
using ScandinavianFood.Controllers;
using ScandinavianFood.Models;
using ScandinavianFood.Models.Repositories;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class PostTests
    {
        [Fact]
        public void AddPostTest()
        {
            var fakePostRepo = new FakePostRepo();
            var controller = new HomeController(fakePostRepo);

            //example posts
            var post1 = new ForumPost()
            {
                Text = "hello",
                Rating = 4,
                Id = 1
            };
            var post2 = new ForumPost()
            {
                Text = "world",
                Rating = 5,
                Id = 2
            };
            //add to repo
            fakePostRepo.Insert(post1);
            fakePostRepo.Insert(post2);

            //actions
            var viewResult = (ViewResult)controller.Forum();

            //assert tests
            var posts = (List<ForumPost>)viewResult.Model;
            Assert.Equal(2, posts.Count);
            Assert.Equal(posts[0].Text, post1.Text);
            Assert.Equal(posts[1].Text, post2.Text);
        }
    }
}
