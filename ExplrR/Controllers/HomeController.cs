﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExplrR.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "SignalR Demo";

            return View();
        }

        public ActionResult About() {
            return View();
        }
    }
}
