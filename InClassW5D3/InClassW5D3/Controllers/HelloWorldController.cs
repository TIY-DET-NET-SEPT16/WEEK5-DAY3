using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InClassW5D3.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index(string name, int id)
        {
            ViewBag.Name = name;
            ViewBag.ID = id;

            return View();
        }
    }
}