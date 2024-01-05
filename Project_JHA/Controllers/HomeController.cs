using Microsoft.AspNetCore.Mvc;

namespace Project_JHA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
