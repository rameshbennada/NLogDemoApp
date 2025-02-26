using NLogDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
namespace NLogDemoApp.Controllers
{
    public class LoginController : Controller
    {
        private static Logger logger = LogManager.GetLogger("myAppLoggerRules");
        // GET: Login
        public ActionResult Login()
        {
            return View("login"); //27/02/2025
        }

        //[HttpPost]
        //public ActionResult Login(UserModel objUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (NlogEntities3 db = new NlogEntities3())
        //        {
        //            var obj = db.users.Where(a => a.username.Equals(objUser.username) && a.password.Equals(objUser.password)).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                Session["UserID"] = obj.id.ToString();
        //                Session["UserName"] = obj.username.ToString();

        //                logger.Info("Login  -- Suceess","", "myAppLoggerRules");

        //                return RedirectToAction("UserDashBoard");
        //            }
        //        }
        //    }
           
        //    logger.Info("Login -- failure");

        //    return View("errorlogin");
            
        //}
        
        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
