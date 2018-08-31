using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Requerimientos_Stack_Csharp.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace Requerimientos_Stack_Csharp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            getBooks();
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

        public JsonResult getBooks()
        {  
            using (var db = new ApplicationDbContext())
            {
                var query = db.Libros
                            .FromSql($@"SELECT s.stor_id 'ID',a.au_fname 'NOMBRE AUTOR',a.au_lname 'APELLIDO AUTOR',
                                    t.title 'TITULO', s.qty 'VENDIDOS', t.pubdate 'FECHA'
                                     FROM dbo.sales s INNER JOIN dbo.titles t
                                    ON s.title_id = t.title_id
                                    INNER JOIN dbo.titleauthor ta
                                    ON t.title_id= ta.title_id
                                    INNER JOIN dbo.authors a
                                    ON a.au_id= ta.au_id
                                    INNER JOIN dbo.pub_info fp
                                    ON fp.pub_id = t.pub_id").ToList();
                           return Json(data:query);

                
            }
        }


    }
}
