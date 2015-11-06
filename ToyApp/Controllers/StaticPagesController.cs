using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyApp.Models;

namespace ToyApp.Controllers
{
    public class StaticPagesController : Controller
    {
        [Route("")]
        public ActionResult Home()
        {
            return View();
        }

        [Route("help")]
        public ActionResult Help()
        {
            return View();
        }

        [Route("about")]
        public ActionResult About()
        {
            return View();
        }

        [Route("contact")]
        public ActionResult Contact()
        {
            return View();
        }

	}
}