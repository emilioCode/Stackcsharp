using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Requerimientos_Stack_Csharp.Models
{
    public class Servicio : IServicio
    {
        public List<string> ObtenerTodos()
        {
            List<string> lista = new List<string>(){"Dominga", "Emilio", "Nicolle", "Juan" };
            return lista;
        }
    }
}
