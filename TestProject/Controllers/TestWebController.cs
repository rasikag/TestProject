using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class TestWebController : Controller
    {
        // GET: TestWeb
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TileView()
        {
            return View();
        }

    }
}