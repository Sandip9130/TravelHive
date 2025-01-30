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
            return View();
        }
        public ActionResult NewExperience()
        {
            return View();
        }
    }
}