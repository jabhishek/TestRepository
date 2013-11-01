using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavascriptPatterns.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FuncArguments()
        {
            return View();
        }
        public ActionResult Chaining()
        {
            return View();
        }
        public ActionResult Timer1()
        {
            return View();
        }
        public ActionResult AsyncModule()
        {
            return View();
        }
        public JsonResult Data()
        {
            var data = Enumerable.Range(0, 10000);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}
