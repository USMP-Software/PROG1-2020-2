using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MascotasApp.Controllers
{
    public class CuentaController : Controller
    {
        private readonly UserManager<IdentityUser> _um;
        private readonly SignInManager<IdentityUser> _sim;
        public CuentaController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            _um = um;
            _sim = sim;
        }
        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _sim.SignOutAsync();

            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public IActionResult Login(string correo, string password)
        {
            var result = _sim.PasswordSignInAsync(correo, password, false, false).Result;

            if (result.Succeeded) {
                return RedirectToAction("index", "home");
            } 

            ModelState.AddModelError("", "Correo y/o contraseña incorrectos");

            return View();
        }

        [HttpPost]
        public IActionResult Registro(string correo, string password)
        {
            var user = new IdentityUser();
            user.Email = correo;
            user.UserName = correo;

            var result = _um.CreateAsync(user, password).Result;

            if (result.Succeeded) {
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View();
        }
    }
}