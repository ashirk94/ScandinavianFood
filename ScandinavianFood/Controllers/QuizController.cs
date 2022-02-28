using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScandinavianFood.Models;

namespace ScandinavianFood.Controllers
{
    public class QuizController : Controller
    {
        //quiz actions
        //require login
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Current = "Quiz";
            QuizVM state = new QuizVM();
            return View(state);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Index(QuizVM state)
        {
            //get score from function in model
            state.Score = state.NumCorrect();

            return View(state);
        }
    }
}
