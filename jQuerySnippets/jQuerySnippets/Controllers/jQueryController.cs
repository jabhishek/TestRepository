using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuerySnippets.Controllers
{
    public class jQueryController : Controller
    {
        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Ajax()
        {
            return View();
        }

        public string PlainHtml()
        {
            return "Hello World!!";
        }

        public JsonResult PlainJSon()
        {
            return Json(new { message = "Hello from JSon" }, JsonRequestBehavior.AllowGet);
        }
    }
}
