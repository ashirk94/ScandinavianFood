using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScandinavianFood.Models;
using ScandinavianFood.Models.Repositories;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ScandinavianFood.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<ForumPost> PostData { get; set; }

        //initialize with repo
        public HomeController(IRepository<ForumPost> postRep)
        {
            PostData = postRep;
        }
        public IActionResult Index()
        {
            return View();
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
        //require login
        [Authorize]
        [HttpGet]
        public IActionResult AddPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPost(ForumPost post)
        {
            //check if user is logged in
            if (HttpContext.User.Identity.Name != null)
            {
                post.User = HttpContext.User.Identity.Name;
            }
            else
            {
                post.User = "Anonymous";
            }
            //if valid post
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
        //require login
        [Authorize]
        [HttpGet]
        public IActionResult Quiz()
        {
            QuizState state = new QuizState();
            return View(state);
        }
        [HttpPost]
        public IActionResult Quiz(QuizState state)
        {
            //get score from function in model
            state.Score = state.NumCorrect();

            return View(state);
        }
    }
}
