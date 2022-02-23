using Microsoft.AspNetCore.Mvc;

namespace FirstCoreProject.Controllers
{
    public class HomeController : Controller
    {


        private readonly ILogger<HomeController> _logger;
        HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            int x = 10;
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
