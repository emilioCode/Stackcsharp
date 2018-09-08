using System;
using System.Collections.Generic;

namespace Requerimientos_Stack_Csharp.Models
{
    public partial class Usuario
    {
        public int Idusuario { get; set; }
        public string Nombrecompleto { get; set; }
        public DateTime? Fecha { get; set; }
        public string NumDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public string Acceso { get; set; }
        public string Habilitado { get; set; }
    }
}
