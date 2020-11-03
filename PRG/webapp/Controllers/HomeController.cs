using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(Contacto contacto)
        {
            if (ModelState.IsValid) 
            {
                // TODO: Hacer algo con los parámetros del objecto contacto
                return RedirectToAction("ContactoConfirmacion");
            }
            
            return View(contacto);
        }

        public IActionResult ContactoConfirmacion()
        {
            return View();
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
