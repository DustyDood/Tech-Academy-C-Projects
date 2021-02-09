using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using MvcTutorial.Models;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.ID = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;



            ////This was throwing an error even though it appeared identical before... I just retyped it.
            ////You know, I think copying the pathway from the security property of files throws an error...
            ////That's what slowed me down another time, I realized. I think the characters used don't match up with
            ////regular letters. Might be a unicode issue?
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\Dusty Zoland\Desktop\MVCTesting.txt", text);

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}