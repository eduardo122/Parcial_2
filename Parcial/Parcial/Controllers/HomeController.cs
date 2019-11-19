using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial.Controllers
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

        public ActionResult Agenda()
        {
            ViewBag.Message = "Agenda Electronica";

            return View();
        }

        public ActionResult Asignaturas()
        {
            ViewBag.Message = "Asignaturas";

            return View();
        }

        public ActionResult Lector()
        {
            ViewBag.Message = "Lector de Archivos";

            return View();
        }

    }
}