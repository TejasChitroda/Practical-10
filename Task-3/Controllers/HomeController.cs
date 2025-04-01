using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // here we are cashing the output for 5 minutes, after 5 minutes the output will be updated
        [OutputCache(Duration = 300)]
        public ActionResult Index()
        {
            //This will return the current server time
            string currentTime = "Current Server Time: " + DateTime.Now.ToString();
            //Content is used to return the plain text
            return Content(currentTime);
        }
    }
}