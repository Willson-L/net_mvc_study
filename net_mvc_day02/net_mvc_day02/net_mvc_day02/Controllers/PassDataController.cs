using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace net_mvc_day02.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PassViewData()
        {
            ViewData["Name"] = "youhao";
            ViewData["Age"] = "21";
            ViewData["Single"] = "Y";
            ViewData["Hometown"] = "Taipei";
            ViewBag.Name = "OKOK";
            return View();
        }
        public ActionResult PetShop()
        {
            ViewData["Company"] = "工程師";
            ViewBag.Address = "ncut e120";
            List<string> petList = new List<string>();
            petList.Add("Java");
            petList.Add("C++");
            petList.Add("python");
            petList.Add("PHP");
            petList.Add("R");
            return View(petList);
        }
        public ActionResult PassTempData() {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料，請聯絡系統管理員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }        
    }
}