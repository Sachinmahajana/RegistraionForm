using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers
{
    public class UserController1 : Controller
    {
        UserdbContext db;
        public UserController1()
        {
            db = new UserdbContext();
        }
        public IActionResult Index()
        {
            List<Userstable> lst = db.Userstables.ToList();
            return View(lst);
        }
        [HttpGet]
        public IActionResult Addemployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addemployee(Userstudmodel stn)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                Userstable std = new Userstable()
                {
                    UserId = stn.UserId,
                    FullName = stn.FullName,
                    MobileNumber = stn.MobileNumber,
                    EmailId = stn.EmailId,
                    Username = stn.Username,
                    Password = stn.Password
                };
                db.Userstables.Add(std);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Userstable u = db.Userstables.Find(id);
            db.SaveChanges();
            return View(u);
        }
        [HttpPost]
        public IActionResult Edit(Userstable us)
        {
            db.Entry<Userstable>(us).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Userstable u = db.Userstables.Find(id);
            db.Userstables.Remove(u);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}  
