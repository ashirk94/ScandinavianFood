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

namespace ScandinavianFood.Controllers
{
    public class HomeController : Controller
    {

        private ForumPostContext postContext { get; set; }
        private PostRepository postData { get; set; }
        private UserRepository userData { get; set; }
        public HomeController(PostRepository postRep, UserRepository userRep)
        {
            postData = postRep;
            userData = userRep;
        }
        //using viewmodels
        public IActionResult Index()
        {
            List<UserModel> users = userData.GetAll().ToList();
            UserViewModel viewModel = new UserViewModel();
            viewModel.Users = users;
            return View(viewModel);
        }

        public IActionResult Overview()
        {
            return View();
        }
        //using repo
        [HttpGet]
        public IActionResult Forum()
        {
            List<ForumPostModel> posts = postData.GetAll().ToList();
            ForumPostViewModel viewModel = new ForumPostViewModel();
            viewModel.Posts = posts;
            viewModel.Post = new ForumPostModel();
            return View(viewModel);
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
                    userData.Insert(user);
                else
                    userData.Update(user);
                userData.Save();
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
                    postData.Insert(post);
                else
                    postData.Update(post);
                postData.Save();
                return RedirectToAction("Forum", "Home");
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
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
