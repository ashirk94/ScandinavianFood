using Microsoft.AspNetCore.Mvc;
using ScandinavianFood.Controllers;
using ScandinavianFood.Models;
using ScandinavianFood.Models.Repositories;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class UserTests
    {
        [Fact]
        public void AddUserTest()
        {
            /*var fakePostRepo = new FakePostRepo();
            var controller = new HomeController(fakePostRepo);

            //example users
            var user1 = new User()
            {
                Username = "Alan",
                Id = "1"
            };
            var user2 = new User()
            {
                Username = "Brian",
                Id = "2"
            };
            var user3 = new User()
            {
                Username = "Josh",
                Id = "3"
            };
            //add to repo
            fakeUserRepo.Insert(user1);
            fakeUserRepo.Insert(user2);
            fakeUserRepo.Insert(user3);

            //actions
            var viewResult = (ViewResult)controller.Index();

            //assert tests
            var users = (List<User>)viewResult.Model;
            Assert.Equal(3, users.Count);
            Assert.Equal(users[0].Username, user1.Username);
            Assert.Equal(users[1].Username, user2.Username);
            Assert.Equal(users[2].Username, user3.Username);*/
        }
    }
}
