using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyApp.Controllers
{
    public class StaticPagesController : Controller
    {
        // Home
        // Help
        // About
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Help()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

	}
}