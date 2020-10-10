using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_MVC.Models
{
    public class EmpleadoModel
    {
        public string Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public double Sueldo { get; set; }

    }
}
