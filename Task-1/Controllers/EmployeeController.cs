using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        // This is action method that will return the view and it take parameter Name and default value is "Tejas" 
        // if we pass the value in the URL then it will take that value otherwise it will take default value
        public ActionResult Index(string Name="Tejas")
        {
            //Passing the value to the view
            ViewBag.Name = Name;
            return View();
        }
    }
}