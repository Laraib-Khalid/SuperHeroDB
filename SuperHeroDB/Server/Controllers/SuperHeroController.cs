using Microsoft.AspNetCore.Mvc;

namespace SuperHeroDB.Server.Controllers
{
    public class SuperHeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
