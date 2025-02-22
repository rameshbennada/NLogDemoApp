using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLogDemoApp.Controllers
{
    public class AjaxTestController : Controller
    {
        
        // GET: /AjaxTest/
        [HttpGet]
        public ActionResult FirstAjax()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FirstAjax(string a)
        {
            return Json("chamara", JsonRequestBehavior.AllowGet);
        }
        
    }
}