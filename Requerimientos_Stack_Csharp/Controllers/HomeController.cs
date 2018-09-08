using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Requerimientos_Stack_Csharp.Models;

namespace Requerimientos_Stack_Csharp.Controllers
{
    public class HomeController : Controller
    {    //inyeccion de dependencias
        public IServicio Servicio { get; }
         //constructor
        public HomeController(IServicio servicio)
        {
            Servicio = servicio;
        }

        public IActionResult Index()
        {
            ViewBag.data = Servicio.ObtenerTodos();
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

     


    }
}
