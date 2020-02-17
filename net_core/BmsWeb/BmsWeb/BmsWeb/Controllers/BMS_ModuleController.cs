﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BmsWeb.Models;
using Newtonsoft.Json;

namespace BmsWeb.Controllers
{
    public class BMS_ModuleController : Controller
    {
        public IActionResult Index()
        {
            BMS_ModuleConnect context = HttpContext.RequestServices.GetService(typeof(BmsWeb.Models.BMS_ModuleConnect)) as BMS_ModuleConnect;
            return View(context.GetBMS_ModuleData("SELECT * FROM module_data where datatime = (select MAX(datatime)from module_data); "));          
        }
        public ContentResult GetData()
        {            
            BMS_ModuleConnect context = HttpContext.RequestServices.GetService(typeof(BmsWeb.Models.BMS_ModuleConnect)) as BMS_ModuleConnect;
            String datajson = context.Getdata("SELECT * FROM module_data; ").ToString();
            return  Content(datajson);
        }
        [HttpPost]
        public ContentResult PostData() {
            BMS_ModuleConnect context = HttpContext.RequestServices.GetService(typeof(BmsWeb.Models.BMS_ModuleConnect)) as BMS_ModuleConnect;
            String datajson=context.ProcessRequest(HttpContext.Request.Form["date1"],HttpContext.Request.Form["date2"],HttpContext.Request.Form["value"]);
            return Content(datajson);
        }        
    }
}