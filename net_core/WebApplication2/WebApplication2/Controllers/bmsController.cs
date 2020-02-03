using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class bmsController : Controller
    {
        public IActionResult Index()
        {
            bms_connect context = HttpContext.RequestServices.GetService(typeof(WebApplication2.Models.bms_connect)) as bms_connect;
            return View(context.GetAllAlbums());
        }
    }
}