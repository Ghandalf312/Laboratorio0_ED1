using LaboratorioI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaboratorioI.Controllers
{
    public class Clientes1 : Controller
    {
        // GET: Clientes1
        public ActionResult Index()
        {
            return View();
        }

        // GET: Clientes1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes1/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var modeloCliente = new ClienteModelo
                {
                    nombreC = collection["nombre cliente"],
                    apellidoC = collection["apellido cliente"],
                    telefonoC = collection["telefono cliente"],
                    descripcionC = collection["Descripcion cliente"]
                };

                //return RedirectToAction("Index");
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Clientes1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
