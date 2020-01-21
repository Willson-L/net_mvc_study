using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            if (User.Identity.Name != "youhao0729@gmail.com") {
                return Content($"{User.Identity.Name}!!!!!!!!");
            }
            ViewBag.Message = "Your application description page.";   
            return View();
        }
        [Authorize(Users ="youhao0729@gmail.com")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}