using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScandinavianFood.Models;
using ScandinavianFood.Models.Repositories;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ScandinavianFood.Controllers
{
    public class HomeController : Controller
    {
        private IPostRepository PostData { get; set; }

        //initialize with repo
        public HomeController(IPostRepository postRep)
        {
            PostData = postRep;
        }
        public IActionResult Index()
        {
            ViewBag.Current = "Home";
            return View();
        }
        public IActionResult Overview()
        {
            return View();
        }
        //forum
        [HttpGet]
        public async Task<IActionResult> Forum()
        {
            List<ForumPost> posts = await PostData.GetAll();
            return View(posts);
        }
        //require login
        [Authorize]
        [HttpGet]
        public IActionResult AddPost()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddPost(ForumPost post)
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
                    await PostData.Insert(post);
                else
                    await PostData.Update(post);
                await PostData.Save();
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
        [Authorize]
        [HttpPost]
        public IActionResult Quiz(QuizState state) // TODO: show success for 3 correct
        {
            //get score from function in model
            state.Score = state.NumCorrect();

            return View(state);
        }
    }
}
