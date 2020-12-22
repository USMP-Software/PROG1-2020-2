using System.Linq;
using MascotasApp.Data;
using MascotasApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MascotasApp.Controllers
{
    public class GestionController : Controller
    {
        private readonly MascotaContext _context;
        public GestionController(MascotaContext c)
        {
            _context = c;
        }

        public IActionResult ListaTipoMascotas()
        {
            var lista = _context.TipoMascotas.ToList();
            var cantidad = HttpContext.Session.GetInt32("CantidadRegistros") ?? 0;

            ViewData["cantidad"] = cantidad;
            
            return View(lista);
        }

        public IActionResult RegistrarTipoMascota()
        {
            var cantidad = HttpContext.Session.GetInt32("CantidadRegistros") ?? 0;

            if (cantidad >= 3) {
                return View("LimiteRegistros");
            }

            return View();
        }

        [HttpPost]
        public IActionResult RegistrarTipoMascota(TipoMascota tm)
        {
            if (ModelState.IsValid) {
                _context.Add(tm);
                _context.SaveChanges();

                // Leer valor actual
                var cantidad = HttpContext.Session.GetInt32("CantidadRegistros") ?? 0;

                // Incrementar la cantidad de registros del usuario
                HttpContext.Session.SetInt32("CantidadRegistros", cantidad + 1);

                return RedirectToAction("ListaTipoMascotas");
            }
            return View(tm);
        }
    }
}