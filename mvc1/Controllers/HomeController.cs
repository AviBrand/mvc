using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NumInfo(double num)
        {
            ViewBag.Num = num;
            return View(ViewBag.Num);
        }

        public ActionResult StringInfo(string str)
        {
            ViewBag.Str = str;
            return View(@model:ViewBag.Str);
        }


    }
}
