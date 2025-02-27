using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelHive.Models;

namespace TravelHive.Controllers
{
    public class HomeController : Controller
    {
        ProjectDbContext db = new ProjectDbContext();
        

        public ActionResult Index()
        {
            var data = db.Users.ToList();
            Session["usersList"] = data;
            return View(data);
        }
        public ActionResult myProfile()
        {
            if (Session["authUser"] != null)
            {
                int uid = Convert.ToInt32(Session["authUser"]);
                ViewBag.userdetail = db.Users.Where(u => u.user_Id == uid).FirstOrDefault();
                return View();
            }
            return RedirectToAction("login", "Account");
        }
        public ActionResult NewExperience()
        {
            if(Session["authUser"] != null)
            {
                return View();
            }
            return RedirectToAction("login", "Account");
        }

        [HttpPost]
        public ActionResult NewExperience(ExperienceDetail detail)
        {
            detail.user_Id = Convert.ToInt32(Session["authUser"]);
            db.ExpDetails.Add(detail);
            int n = db.SaveChanges();
            if (n > 0)
            {
                ViewBag.postmsg = "Post uploaded successfully";
            }
            return View();
        }
    }
}