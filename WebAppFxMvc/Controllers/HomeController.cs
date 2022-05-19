﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFxData.Services;

namespace WebAppFxMvc.Controllers
{
    public class HomeController : Controller
    {
        IEmployeeData _db;

        public HomeController(IEmployeeData db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}