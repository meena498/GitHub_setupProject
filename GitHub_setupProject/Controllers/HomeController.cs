using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHub_setupProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string var = "shubham";
              

            return View();
        }

        public ActionResult About()
        {
        string var = "";
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
