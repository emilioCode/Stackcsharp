using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Requerimientos_Stack_Csharp.Models;

namespace Requerimientos_Stack_Csharp.Controllers
{
    public class UsuariosController : Controller
    {
        public dbDominicanoSRLContext db = new dbDominicanoSRLContext();
        public IActionResult Index()
        {
            var data = db.Usuario;
            return View(data);
        }
    }
}