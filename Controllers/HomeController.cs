using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppBootstrap.Models;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using AppBootstrap.Model;

namespace AppBootstrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Denegado")]
        public IActionResult Denegado()
        {
            return View();
        }
        public IActionResult Servicios()
        {
            return View();
        }
        public IActionResult Funcionalidades()
        {
            return View();
        }
        public IActionResult Ventajas()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Registro(Usuario myUsuario)
        {
            var db = new bootstrapContext();
            var existe = db.Cliente.Find(myUsuario.Id);
            if (existe == null)
            {
                db.Usuario.Add(myUsuario);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                ViewData["msj"] = $"El Id {myUsuario.Id} Ya Existe";
                return View();
            }

        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles ="adm")]
        public IActionResult Privado()
        {
            return View();
        }
        [Authorize]
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        [HttpGet("Login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Validar(string username, string password, string returnUrl)
        {
            var db = new bootstrapContext();
            var usuarioLogeado = db.Usuario.FirstOrDefault(u => u.Apodo==username && u.Contrasena == password);
            if (usuarioLogeado != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", usuarioLogeado.Apodo));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                claims.Add(new Claim(ClaimTypes.Name, usuarioLogeado.Nombre));
                claims.Add(new Claim(ClaimTypes.Role, usuarioLogeado.Rol));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return Redirect(returnUrl);
            }
            else
            {
                ViewData["ReturnUrl"] = returnUrl;
                TempData["Error"] = "El usuario o la contraseña no son validos";
                return View("Login");

            }
        }
        [Authorize]
        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
