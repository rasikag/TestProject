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

        public ActionResult TestKendo()
        {
            return View();
        }

        public ActionResult SriLankaMap()
        {
            return View();
        }

        public ActionResult DistrictDetail()
        {
            return View();
        }

        public ActionResult AddComment()
        {
            return View();
        }


    }
}