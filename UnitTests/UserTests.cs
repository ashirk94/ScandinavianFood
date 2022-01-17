using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ScandinavianFood.Models;
using ScandinavianFood.Models.Repositories;
using ScandinavianFood.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTests
{
    public class UserTests
    {
        [Fact]
        public void AddUserTest()
        {
            var fakePostRepo = new FakePostRepo();
            var fakeUserRepo = new FakeUserRepo();
            var controller = new HomeController(fakePostRepo, fakeUserRepo);

            //example users
            var user1 = new UserModel()
            {
                Name = "Alan",
                Id = 1
            };
            var user2 = new UserModel()
            {
                Name = "Brian",
                Id = 2
            };
            var user3 = new UserModel()
            {
                Name = "Josh",
                Id = 3
            };
            //add to repo
            fakeUserRepo.Insert(user1);
            fakeUserRepo.Insert(user2);
            fakeUserRepo.Insert(user3);

            //actions
            var viewResult = (ViewResult)controller.Index();

            //assert tests
            var users = (List<UserModel>)viewResult.Model;
            Assert.Equal(3, users.Count);
            Assert.Equal(users[0].Name, user1.Name);
            Assert.Equal(users[1].Name, user2.Name);
            Assert.Equal(users[2].Name, user3.Name);
        }
    }
}
