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
<<<<<<< HEAD
        public ActionResult RecordatorioProgreso()
        {

            return View();
        }

        [HttpGet]
=======
>>>>>>> main
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

<<<<<<< HEAD
        [HttpGet]
        public ActionResult Foro()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DetalleForo()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CrearPublicacion()
        {
            return View();
        }
=======
>>>>>>> main

        [HttpGet]
        public ActionResult Profile()
        {
            return View();
        }

        [HttpGet]
<<<<<<< HEAD
        public ActionResult MisCertificados()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DetalleCertificados()
        {
            return View();
        }

        [HttpGet]
=======
>>>>>>> main
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