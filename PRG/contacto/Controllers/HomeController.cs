using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using contacto.Models;
using contacto.Data;

namespace contacto.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebAppContext _context;

        public HomeController(WebAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contactos = _context.Contactos.Where(x => x.Mensaje != null).ToList();

            return View(contactos);
        }


        [HttpPost]
        public IActionResult Borrar(int id) {

            // Búsqueda del objeto que se quiere borrar usando el id
            var contacto = _context.Contactos.FirstOrDefault(x => x.Id == id);

            _context.Remove(contacto);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(Contacto c)
        {
            if (ModelState.IsValid) {

                _context.Add(c);
                _context.SaveChanges();

                // Guardar en BD
                return RedirectToAction("Index");
            }

            return View(c);
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
