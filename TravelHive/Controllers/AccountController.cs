using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelHive.Models;

namespace TravelHive.Controllers
{
    public class AccountController : Controller
    {
        ProjectDbContext db = new ProjectDbContext();


        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(User c)
        {
            var cred = db.Users.Where(crd => crd.email == c.email).FirstOrDefault();   
            return View();
        }


        public ActionResult signup()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Signup(User u)
        {
            u.bio = "New to TravellHive";
            u.profile_photo = "~/images/profile_placeholder.png";
            try
            {
                var userdt = db.Users.FirstOrDefault(ch => ch.username == u.username);
                var usreml = db.Users.FirstOrDefault(ch => ch.email == u.email);

                if (userdt != null)
                {
                    TempData["insertMessage"] = "Username already exists!";
                }
                else if (usreml != null)
                {
                    TempData["insertMessage"] = "Email already exists!";
                }
                else if (ModelState.IsValid)
                {
                    db.Users.Add(u);
                    int a = db.SaveChanges();

                    if (a > 0)
                    {
                        ViewBag.insertMessage = "Data inserted successfully!";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["insertMessage"] = "Data not inserted.";
                    }
                }
                else
                {
                    TempData["insertMessage"] = "Invalid data!";
                }
            }
            catch (Exception ex)
            {
                TempData["insertMessage"] = $"Error: {ex.Message}";
            }

            return View();
        }

        //[HttpPost]
        //public ActionResult signup(User u)
        //{
        //    //var userdt = db.Users.Where(ch => ch.username == u.username).FirstOrDefault();
        //    //var usreml = db.Users.Where(ch => ch.email == u.email).FirstOrDefault();
        //    //if (userdt != null)
        //    //{
        //    //    TempData["insertMessage"] = "<script>alert('Username already exisists !')</script>";
        //    //}
        //    //else if (usreml != null)
        //    //{
        //    //    TempData["insertMessage"] = "<script>alert('email already exisists !')</script>";
        //    //}
        //    //else if(ModelState.IsValid == true)
        //    //{
        //        db.Users.Add(u);
        //        int a = db.SaveChanges();
        //        if (a > 0)
        //        {
        //            TempData["insertMessage"] = "<script>alert('Data inserted !')</script>";
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            ViewBag.insertMessage = "<script>alert('Data not inserted !')</script>";
        //        }
        //    //}
        //    return View();
        //}
    }
}