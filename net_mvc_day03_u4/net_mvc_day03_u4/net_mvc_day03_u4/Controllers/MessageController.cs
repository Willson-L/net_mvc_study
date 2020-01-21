using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using net_mvc_day03_u4.Models;
using net_mvc_day03_u4.Service;

namespace net_mvc_day03_u4.Controllers
{
    public class MessageController : Controller
    {
        messageBDService data = new messageBDService();
        // GET: Message
        public ActionResult Index()
        {
            return View(data.GetData());
        }
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Article_title, string Content) {
            data.DBSerivce(Article_title, Content);
            return RedirectToAction("Index");
        }
    }
}