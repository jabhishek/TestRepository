using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace HTML5Forms.Controllers
{
    public class TestController : Controller
    {
        public ActionResult LongRunning()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);    
            }
            
            return View();
        }
        public ActionResult ModerateRunning()
        {
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(100);
            }
            return View();
        }
        public ActionResult Fast()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
            }
            return View();
        }
        public ActionResult Instant()
        {
            return View();
        }

    }
}
