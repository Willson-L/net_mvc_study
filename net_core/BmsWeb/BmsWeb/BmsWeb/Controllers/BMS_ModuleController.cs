using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BmsWeb.Models;

namespace BmsWeb.Controllers
{
    public class BMS_ModuleController : Controller
    {
        public IActionResult Index()
        {
            BMS_ModuleConnect context = HttpContext.RequestServices.GetService(typeof(BmsWeb.Models.BMS_ModuleConnect)) as BMS_ModuleConnect;
            return View(context.GetAllBMS_Module());
        }
    }
}