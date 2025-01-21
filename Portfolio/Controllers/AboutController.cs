using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Hero()
        {
            return View();
        }
    }
}
