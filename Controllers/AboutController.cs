using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class AboutController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}