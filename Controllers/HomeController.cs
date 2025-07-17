using Microsoft.AspNetCore.Mvc;

namespace DigitalParticles.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
