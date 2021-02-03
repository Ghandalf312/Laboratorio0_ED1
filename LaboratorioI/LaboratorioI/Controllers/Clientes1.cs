using LaboratorioI.Models;
using LaboratorioI.Models.Storage;
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
            return View(Singleton.Instance.listaClientes);
        }

        // GET: Clientes1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var nuevoCliente = new Models.ClienteModelo
                {
                    nombreC = collection["nombreC"],
                    apellidoC = collection["apellidoC"],
                    telefonoC = collection["telefonoC"],
                    descripcionC = collection["descripcionC"]
                };

                Singleton.Instance.listaClientes.Add(nuevoCliente);
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
