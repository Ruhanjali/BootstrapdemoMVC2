using Bootstrapdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrapdemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ViewResult Register()
        {
            return View();
        }
           
        [HttpPost]
        public ViewResult Register(RegisterViewModel model)
        {
            return View();
        }

        public ViewResult Student()
        {
            return View();
        }
    }
}