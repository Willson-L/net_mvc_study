using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using net_mvc_day05.Models;
namespace net_mvc_day05.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ReportList_A()
        {
            TCP_ethernet_ImmediatelyEntities db = new TCP_ethernet_ImmediatelyEntities();
            List<Module_data> GetList()
            {

                List<Module_data> Module_dataList = db.Module_data.OrderBy(Module_data => Module_data.Module_id).ToList();
                return Module_dataList;
            }
            Module_data NewData = new Module_data();
            return View(GetList());
        }
        public ActionResult ReportList_B() {
            return View();
        }
    }
}