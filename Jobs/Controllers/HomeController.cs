using Jobs.Data;
using Jobs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jobs.Controllers
{
    public class HomeController : Controller
    {
        private readonly JobContext _db;

        public HomeController(JobContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            if (datalogin.fallNamel == "")
            {
                return RedirectToAction("Index", "login");
            }
            else
            {
                ViewBag.fallName = datalogin.fallNamel;
                return View();
            }
        }
        public IActionResult About()
        {
            if (datalogin.fallNamel == "")
            {
                return RedirectToAction("Index", "login");
            }
            else
            {
                ViewBag.fallName = datalogin.fallNamel;
                return View();
            }
        }
        [HttpGet]
        public IActionResult Contact()
        {
            if (datalogin.fallNamel == "")
            {
                return RedirectToAction("Index", "login");
            }
            else
            {
                ViewBag.fallName = datalogin.fallNamel;
                return View();
            }
        }
        [HttpPost]
        public IActionResult Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var contact = new ContactModel()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Message = model.Message,
                    Subject = model.Subject,
                };
                _db.Contacts.Add(contact);
                _db.SaveChanges();
                return RedirectToAction("index", "Home");
            }
            else
            {
                return View();
            }
        }
        public IActionResult FindJobs()
        {
            var Ads = _db.Ad.OrderByDescending(p=>p.Id).ToList();
            return View(Ads);
        }
    }
}
