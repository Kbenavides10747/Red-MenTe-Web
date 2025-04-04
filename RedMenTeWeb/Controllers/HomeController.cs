using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedMenTeWeb.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegistrarCuenta()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Proyectos()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]

        public ActionResult RecuperarContrasenna()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Calendario()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Profile()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Seguridad()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Admin()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Estadisticas()
        {
            return View();
        }
    }
}