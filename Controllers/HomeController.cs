using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unidad2Actividad1.Models;

namespace Unidad2Actividad1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sumar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Resultado(Ejemplo em)
        {
            return View(em);
        }

    }
}
