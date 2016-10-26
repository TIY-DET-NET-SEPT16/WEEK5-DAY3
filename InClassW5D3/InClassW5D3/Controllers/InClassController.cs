using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InClassW5D3.Controllers
{
    public class InClassController : Controller
    {
        // GET: InClass
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hey()
        {
            return View();
        }

    }
}