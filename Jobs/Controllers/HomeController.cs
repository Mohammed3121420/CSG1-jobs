using Microsoft.AspNetCore.Mvc;

namespace Jobs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult FindJobs()
        {
            return View();
        }
        public IActionResult JobsDetails()
        {
            return View();
        }
    }
}
