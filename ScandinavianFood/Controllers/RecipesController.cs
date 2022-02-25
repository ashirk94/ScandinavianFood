using Microsoft.AspNetCore.Mvc;

namespace ScandinavianFood.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Recipes()
        {
            ViewBag.Current = "Recipes";
            return View();
        }
    }
}
