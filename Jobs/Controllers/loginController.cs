using Jobs.Data;
using Microsoft.AspNetCore.Mvc;

namespace Jobs.Controllers
{
    public static class datalogin
    {
        public static string fallNamel = "";
    }
    public class loginController : Controller
    {
        private readonly JobContext _db;
        public loginController(JobContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.error = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(string userOrEmail, string pass)
        {
            if (_db.dbsignUp.Any(x => x.username == userOrEmail && x.password == pass))
            {
                var loggedInUser = _db.dbsignUp.FirstOrDefault(x => x.username == userOrEmail && x.password == pass);
                datalogin.fallNamel = loggedInUser.fallName;
                string value = datalogin.fallNamel;

                //var Admin =_db.dbsignUp.FirstOrDefault(x => x.type == "3");
                if (loggedInUser.type == "3")
                {
                    return RedirectToAction("index", "Admin");
                }
                return RedirectToAction("index", "Home");
            }
            else
            {
                ViewBag.error = "Invalid entry";
                return View();
            }
        }

    }
}
