using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_MVC.Models;

namespace Proyecto_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<EmpleadoModel> lista = new List<EmpleadoModel>();
            EmpleadoModel Emp = new EmpleadoModel();
            Emp.Id_Empleado = "001";
            Emp.Nombre = "Diana";
            Emp.Email = "Diana@gmail.com";
            Emp.Edad = 21;
            Emp.Telefono = "6761118987";
            Emp.Direccion = "C. Lucio Rosales";
            Emp.Sueldo = 200;
            lista.Add(Emp);

            EmpleadoModel Emp2 = new EmpleadoModel();
            Emp2.Id_Empleado = "002";
            Emp2.Nombre = "Andrea";
            Emp2.Email = "Andrea@gmail.com";
            Emp2.Edad = 20;
            Emp2.Telefono = "6761845298";
            Emp2.Direccion = "Av. Ignacio Allende";
            Emp2.Sueldo = 100;
            lista.Add(Emp2);

            EmpleadoModel Emp3 = new EmpleadoModel();
            Emp3.Id_Empleado = "003";
            Emp3.Nombre = "Mario";
            Emp3.Email = "Mario@gmail.com";
            Emp3.Edad = 20;
            Emp3.Telefono = "6768794563";
            Emp3.Direccion = "Av. Morelos";
            Emp3.Sueldo = 200;
            lista.Add(Emp3);

            EmpleadoModel Emp4 = new EmpleadoModel();
            Emp4.Id_Empleado = "004";
            Emp4.Nombre = "Ana";
            Emp4.Email = "Ana@gmail.com";
            Emp4.Edad = 20;
            Emp4.Telefono = "6769876541";
            Emp4.Direccion = "Av. Heroes de Chapultepec";
            Emp4.Sueldo = 200;
            lista.Add(Emp4);


            return View(lista);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
