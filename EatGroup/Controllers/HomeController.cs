﻿using System;
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
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Favorite()
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
    }
}