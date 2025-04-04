﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_4.Controllers
{
    public class HomeController : Controller
    {
        //For handling the exception 
        //Three Steps :   1.Add [HandleError] on which you are willing to check exception
        //                2.Add Error.cshtml at View/Shared Folder for rendering if any exception come
        //                3.Add <customErrors mode = "On" /> int web.config file inside System.Web Tag

        // HandleError is used to handle the exception
        [HandleError]
        public ActionResult Index()
        {
            int a = 0;
            //This will throw an exception
            int b = 10 / a;
            return View();
        }
    }
}