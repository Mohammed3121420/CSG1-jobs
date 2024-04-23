using Jobs.Models;
using Microsoft.AspNetCore.Mvc;
using Jobs.Data;
using System;

namespace Jobs.Controllers
{
    public class signUpController : Controller
    {
        private readonly JobContext _db;

        public signUpController(JobContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.msgUser = "";
            ViewBag.msgEmail = "";
            ViewBag.msgPassword = "";



            return View();
        }
        [HttpPost]
        public IActionResult Index(signUpModel Input, string confirmPassword)
        {
            if (ModelState.IsValid)
            {
                if (confirmPassword == Input.password)
                {
                    if (_db.dbsignUp.Where(x => x.username == Input.username).ToList().Count != 0)
                    {
                        ViewBag.msgUser = "Username is not available ";
                        return View();
                    }
                    else if (_db.dbsignUp.Where(x => x.email == Input.email).ToList().Count != 0)
                    {
                        ViewBag.msgEmail = "Email is already registered";
                        return View();
                    }
                    else
                    {
                        string typeAccount = "";
                        if (Input.type == "Personal")
                        {
                            typeAccount = "1";
                        }
                        else
                        {
                            typeAccount = "0";
                        }
                        var counter = new signUpModel()
                        {
                            fallName = Input.fallName,
                            username = Input.username,
                            email = Input.email,
                            phone = Input.phone,
                            city = Input.city,
                            password = Input.password,
                            type = typeAccount,

                        };
                        _db.dbsignUp.Add(counter);
                        _db.SaveChanges();
                        return RedirectToAction("Contact", "Home");
                    }

                }
                else
                {
                    ViewBag.msgPassword = "The password does not match";
                    return View();
                }
            }
            else
            {
                return View();
            }



        }
    }
}
