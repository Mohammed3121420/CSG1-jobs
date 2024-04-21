using Jobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Jobs.Controllers
{
    public class signUpController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(signUpModel model, string confirmPassword)
        {
            if (confirmPassword == model.password)
            {
                ViewBag.x = 1;
                return View();
            }
            else
            {
                ViewBag.x = 0;
                return View();
            }

        }

    }
}
