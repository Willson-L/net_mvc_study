using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace net_mvc_day02.Controllers
{
    public class ErrorHandlerController : Controller
    {
        // GET: ErrorHandler
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ErrorMessage() {
            if (!TempData.ContainsKey("ErrorMessage")) {
                return new EmptyResult();
            }
            TempData.Keep();

            return View();
        }
    }
}