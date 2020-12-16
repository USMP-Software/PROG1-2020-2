using System.Linq;
using MascotasApp.Data;
using MascotasApp.Models;
using Microsoft.AspNetCore.Authorization;
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
            
            return View(lista);
        }

        [Authorize]
        public IActionResult RegistrarTipoMascota()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult RegistrarTipoMascota(TipoMascota tm)
        {
            if (ModelState.IsValid) {
                _context.Add(tm);
                _context.SaveChanges();
                return RedirectToAction("ListaTipoMascotas");
            }
            return View(tm);
        }
    }
}