﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spring.demo.IBLL;

namespace Spring.demo.Web.Controllers
{
    public class HomeController : Controller
    {
        protected string _string { get; set; }
        protected IBLL1 _bll1 { get; set; }

        public ActionResult Index()
        {
            if (!string.IsNullOrEmpty(_string))
            {
                System.Diagnostics.Trace.WriteLine(_string);
            }
            if (_bll1 != null)
            {
                System.Diagnostics.Trace.WriteLine("_bll1");
                //return Content("_bll1");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}