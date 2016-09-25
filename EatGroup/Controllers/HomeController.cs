using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EatGroup.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            //return Map();
            return RedirectToAction("message");
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }

        public ActionResult Favorite()
        {
            return View();
        }

        public ActionResult Group()
        {
            return View();
        }

        public ActionResult detail()
        {
            return View();
        }
        
        public ActionResult message()
        {
            return View();
        }

        public ActionResult Rotary()
        {
            return View();
        }
    }
}