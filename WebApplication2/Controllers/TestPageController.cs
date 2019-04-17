using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestPage.Controllers
{
    public class TestPageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int numTimes = 1)
        {
            string message = "Hello " + name + ", NumTimes is: " + numTimes;
            return "" + Server.HtmlEncode(message) + "";
        }
    }
}