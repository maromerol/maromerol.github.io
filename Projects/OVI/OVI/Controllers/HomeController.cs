using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OVI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MaterialdeLecturas()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult MaterialMultimedia()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Participantes()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ManualII()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult IntroducionHTML()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult EstructuraHTML_CSS()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult IntroducionCSS3()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}