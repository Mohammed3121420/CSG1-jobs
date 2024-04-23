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
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
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
                return RedirectToAction("Contact");
            }
            else
            {
                return View();
            }
        }
        public IActionResult FindJobs()
        {
            return View();
        }
    }
}
