using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTML5Forms.Models;

namespace HTML5Forms.Controllers
{
    public class CSSController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HTML1()
        {
            return View();
        }

        public ActionResult CSSPage1()
        {
            return View();
        }

        public ActionResult AttributeSelector()
        {
            return View();
        }

        public ActionResult PseudoSelector()
        {
            return View();
        }

        public ActionResult ChildSelectors()
        {
            return View();
        }

        public ActionResult PseudoClassSelectors()
        {
            return View();
        }

        public ActionResult DynamicPseudoClassSelectors()
        {
            return View();
        }

        public ActionResult BordersAndBackgrounds()
        {
            return View();
        }

        public ActionResult BoxShadow()
        {
            return View();
        }

        public ActionResult BoxModel1()
        {
            return View();
        }

        public ActionResult BoxModel2()
        {
            return View();
        }

        public ActionResult BoxModel3()
        {
            return View();
        }

        public ActionResult BoxModel4()
        {
            return View();
        }

        public ActionResult Layout1()
        {
            return View();
        }
        
        public ActionResult LayoutMultiColumn()
        {
            return View();
        }
    
        public ActionResult LayoutTable()
        {
            return View();
        }
        
        public ActionResult StylingText1()
        {
            return View();
        }

        public ActionResult FontFace()
        {
            return View();
        }

        public ActionResult Transition()
        {
            return View();
        }

        public ActionResult Animation()
        {
            return View();
        }

        public ActionResult StylingTable()
        {
            return View();
        }

        public ActionResult StylingLists()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            // TODO: Add insert logic here
            List<KeyValuePair> list = new List<KeyValuePair>();
            foreach (var key in collection.AllKeys)
            {
                var value = collection[key];
                list.Add(new KeyValuePair { Key = key, Value = value });
            }

            return View(list);
        }
    }
}
