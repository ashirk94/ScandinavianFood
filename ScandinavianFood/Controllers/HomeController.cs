using ScandinavianFood.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ScandinavianFood.Models.Repositories;

namespace ScandinavianFood.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<ForumPostModel> PostData { get; set; }
        private IRepository<UserModel> UserData { get; set; }
        //initialize with repos
        public HomeController(IRepository<ForumPostModel> postRep, IRepository<UserModel> userRep)
        {
            PostData = postRep;
            UserData = userRep;
        }
        //viewmodel to see users
        public IActionResult Index()
        {
            List<UserModel> users = UserData.GetAll().ToList();
            return View(users);
        }

        public IActionResult Overview()
        {
            return View();
        }
        //forum
        [HttpGet]
        public IActionResult Forum()
        {
            List<ForumPostModel> posts = PostData.GetAll().ToList();
            return View(posts);
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(UserModel user)
        {
            if (ModelState.IsValid)
            {
                if (user.Id == 0)
                    UserData.Insert(user);
                else
                    UserData.Update(user);
                UserData.Save();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPost(ForumPostModel post)
        {
            if (ModelState.IsValid)
            {
                if (post.Id == 0)
                    PostData.Insert(post);
                else
                    PostData.Update(post);
                PostData.Save();
                return RedirectToAction("Forum", "Home");
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //quiz actions
        [HttpGet]
        public IActionResult Quiz()
        {
            ViewBag.Score = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Quiz(QuizState state)
        {
            //get score from function in model
            ViewBag.Score = state.NumCorrect();

            return View();
        }
    }
}
