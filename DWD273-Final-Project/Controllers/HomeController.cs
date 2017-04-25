using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DWD273_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This Website's Purpose";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Have an issue that can't be resolved with a ticket?";

            return View();
        }

        

        
    }
}