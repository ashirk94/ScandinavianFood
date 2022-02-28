using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScandinavianFood.Models;
using System.Diagnostics;

namespace ScandinavianFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Current = "Home";
            return View();
        }
        //error page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorVM { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
