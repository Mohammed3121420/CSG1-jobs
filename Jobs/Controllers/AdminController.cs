using Jobs.Data;
using Jobs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jobs.Controllers
{
    public class AdminController : Controller
    {
        private readonly JobContext _db;
        public AdminController(JobContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var job = _db.Ad.OrderByDescending(p => p.Id).ToList();
            return View(job);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var job = _db.Ad.Find(Id);

            if (job == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            var create = new CreateJob()
            {
                JobName = job.JobName,
                JobDescription = job.JobDescription,
                Address = job.Address,
                Requirements = job.Requirements,
            };
            ViewData["Ad"] = job.Id;
            return View(create);
        }
        [HttpPost]
        public IActionResult Edit(int Id, CreateJob cj)
        {
            var job = _db.Ad.Find(Id);

            if (job == null)
            {
                return RedirectToAction("Index", "Admin");
            }

            if (!ModelState.IsValid)
            {
                ViewData["Ad"] = job.Id;
                return View(cj);
            }

            job.JobName = cj.JobName;
            job.JobDescription = cj.JobDescription;
            job.Address = cj.Address;
            job.Requirements = cj.Requirements;
            _db.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }
        public IActionResult Delete(int Id)
        {
            var job = _db.Ad.Find(Id);
            if (job == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            _db.Ad.Remove(job);
            _db.SaveChanges(true);
            return RedirectToAction("Index", "Admin");

        }
    }
}
