using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace session.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }


        public ActionResult Index1()
        {
            ViewBag.userId = Session["UserID"].ToString();
            ViewBag.userName = Session["UserName"].ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            string a = Session["UserID"].ToString();
            string b = Session["UserName"].ToString();

            return new RedirectResult("http://localhost:58225/Home/About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            string a = Session["UserID"].ToString();
            string b = Session["UserName"].ToString();

            return new RedirectResult("http://localhost:58166/Home/index");
        }
    }
}