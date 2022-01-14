using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ScandinavianFood.Models;
using ScandinavianFood.Models.Repositories;
using ScandinavianFood.Controllers;

namespace UnitTests
{
    public class PostTests
    {
        [Fact]
        public void AddPostTest()
        {
            var fakePostRepo = new FakePostRepo();
            var fakeUserRepo = new 
            var controller = new HomeController(fakePostRepo);
            //actions
            var viewResult = (ViewResult)controller.Index());

            //assert tests
        }
    }
}
