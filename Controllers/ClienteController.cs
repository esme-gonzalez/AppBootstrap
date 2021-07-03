using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppBootstrap.Models;
using AppBootstrap.Model;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace AppBootstrap.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index(int? page)
        {
            var db = new bootstrapContext();
            var pageNumber = page ?? 1;
            int pageSize = 6;
            var Cliente = db.Cliente.ToPagedList(pageNumber, pageSize);
            return View(Cliente);
        }

      

        [Authorize]
        public IActionResult Crear()
        {
            return View();
        }

        [Authorize(Roles = "adm")]
        [ HttpPost]
        public IActionResult Crear(Cliente myCliente)
        {
            var db = new bootstrapContext();
            var existe = db.Cliente.Find(myCliente.Codigo);
            if (existe == null)
            {
                db.Cliente.Add(myCliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["msj"] = $"El Codigo {myCliente.Codigo} Ya Existe";
                return View();
            }
            
        }
        [Authorize(Roles = "adm, vendedor")]
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var db = new bootstrapContext();
            var myCliente = db.Cliente.Find(id);
            return View(myCliente);
        }
        [Authorize(Roles = "adm, vendedor")]
        [HttpPost]
        public IActionResult Editar(Cliente myCliente)
        {
            var db = new bootstrapContext();
            var objCliente = db.Cliente.Find(myCliente.Codigo);
            objCliente.Nombre = myCliente.Nombre;
            objCliente.Apellido = myCliente.Apellido;
            objCliente.Correo = myCliente.Correo;
            objCliente.Celular = myCliente.Celular;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "adm, vendedor")]
        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var db = new bootstrapContext();
            var myCliente = db.Cliente.Find(id);
            return View(myCliente);
        }
        [Authorize(Roles = "adm")]
        [HttpGet]
        public IActionResult Borrar(int id)
        {
            var db = new bootstrapContext();
            var myCliente = db.Cliente.Find(id);
            return View(myCliente);
        }
        [Authorize(Roles = "adm, vendedor")]
        [HttpPost, ActionName("Borrar")]
        public IActionResult ConfirmarBorrar(int id)
        {
            var db = new bootstrapContext();
            var myCliente = db.Cliente.Find(id);
            db.Remove(myCliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        }
}
