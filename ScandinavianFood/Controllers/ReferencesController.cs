using Microsoft.AspNetCore.Mvc;

namespace ScandinavianFood.Controllers
{
    public class ReferencesController : Controller
    {
        public IActionResult References()
        {
            return View();
        }
        public IActionResult Books()
        {
            return View();
        }
        public IActionResult Links()
        {
            return View();
        }
    }
}
