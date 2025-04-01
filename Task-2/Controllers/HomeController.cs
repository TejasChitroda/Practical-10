using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_2.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }

        //ActionResult is The Parent class of all the result types in MVC like
        //ViewResult, PartialViewResult, RedirectResult, RedirectToRouteResult, JsonResult, ContentResult, FileContentResult, EmptyResult, JavaScriptResult
        public ActionResult ActionResultDemo()
        {
            return Content("Return type is ActionResult and here we are returning Content");
        }

        //JsonResult - Returns JSON data
        public JsonResult GetJsonData()
        {
            var data = new { Name = "Tejas Chitroda", Age = 20 };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //ContentResult - Returns plain text
        public ContentResult GetText()
        {
            return Content("Hello, this is a plain text response!");
        }

        //EmptyResult - Returns nothing
        public EmptyResult DoNothing()
        {
            return new EmptyResult();
        }

        //FileContentResult - Returns a file (download)
        public FileResult DownloadFile()
        {
            string filePath = Server.MapPath("~/App_Data/TextFile.txt");

            if (System.IO.File.Exists(filePath))
            {
                return File(filePath, "text/plain", "TextFile.txt");
            }
            else
            {
                return null;
            }
        }

        //RedirectResult - Redirects to another action
        public RedirectResult RedirectToGoogle()
        {
            return Redirect("https://www.google.com");
        }

        //RedirectToRouteResult - Redirects to another action(in this case Redirecting To GetText)
        public RedirectToRouteResult RedirectToGetText()
        {
            return RedirectToAction("GetText");
        }

        //JavaScriptResult - Returns JavaScript code
        public JavaScriptResult GetJavaScript()
        {
            return JavaScript("alert('Hello World');");
        }

        public PartialViewResult GetPartialView()
        {
            return PartialView("GetPartialView");
        }
    }
}