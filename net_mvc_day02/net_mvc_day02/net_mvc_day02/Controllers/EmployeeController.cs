using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using net_mvc_day02.Models;
namespace net_mvc_day02.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeList ()
        {
            List<Employee> employees = new List<Employee> {
                new Employee { ID=10001, Name="youhao", Phone="0912345678", Email="@gmail.com"},
                new Employee { ID=10002, Name="youhao", Phone="0912345678", Email="@gmail.com"},
                new Employee { ID=10003, Name="youhao", Phone="0912345678", Email="@gmail.com"},
                new Employee { ID=10004, Name="youhao", Phone="0912345678", Email="@gmail.com"},
                new Employee { ID=10005, Name="youhao", Phone="0912345678", Email="@gmail.com"},
                new Employee { ID=10006, Name="youhao", Phone="0912345678", Email="@gmail.com"},
                new Employee { ID=10007, Name="youhao", Phone="0912345678", Email="@gmail.com"},
                new Employee { ID=10008, Name="youhao", Phone="0912345678", Email="@gmail.com"}
            };
            return View(employees);
        }
    }
}