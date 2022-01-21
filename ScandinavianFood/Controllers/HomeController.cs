using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScandinavianFood.Models;
using ScandinavianFood.Models.Repositories;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace ScandinavianFood.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<ForumPost> PostData { get; set; }
        private readonly SiteDbContext UserData;
        //initialize with repo
        public HomeController(IRepository<ForumPost> postRep)
        {
            PostData = postRep;
        }
        //viewmodel to see users
        public IActionResult Index()
        {
            if (UserData == null) return View();
            List<IdentityUser> users = UserData.Users.ToList();
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
            List<ForumPost> posts = PostData.GetAll().ToList();
            return View(posts);
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                UserData.Add(user);
                UserData.SaveChanges();
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
        public IActionResult AddPost(ForumPost post)
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
