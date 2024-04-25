using Jobs.Data;
using Microsoft.AspNetCore.Mvc;
using Jobs.Models;

namespace Jobs.Controllers
{
    public class AdController : Controller
    {
        private readonly JobContext _db;
        public AdController(JobContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateJob model)
        {
            if (ModelState.IsValid)
            {
                var create = new CreateJob()
                {
                    JobName = model.JobName,
                    JobDescription = model.JobDescription,
                    Address = model.Address,
                    Requirements = model.Requirements,
                };

                _db.Ad.Add(create);
                _db.SaveChanges();
                return RedirectToAction("FindJobs", "Home");
            }
            else
            {
                return View();

            }
        }
    }
}
