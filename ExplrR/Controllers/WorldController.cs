using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExplrR.Controllers
{
    public class WorldController : Controller
    {
        //
        // GET: /World/

        public ActionResult Map()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult JoinWorld() {
            return View();
        }

    }
}
