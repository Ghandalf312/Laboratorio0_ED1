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

        public ActionResult Ordenamiento()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ordenamiento(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string eleccion = collection["tipoOrdenamiento"];
                List<ClienteModelo> lista = Singleton.Instance.listaClientes;

                if (eleccion.ToLower() == "nombreC")
                {
                    //ordenar por nombre
                    //Storage.Instance.clientList.Sort((x, y) => x.nombre.CompareTo(y.nombre));
                    for (int i = 0; i < lista.Count - 1; i++)
                    {
                        for (int j = 0; j < lista.Count - i - 1; j++)
                        {
                            if (CompararNombres(lista[j].nombreC, lista[j + 1].nombreC))
                            {
                                ClienteModelo AuxClient = lista[j];
                                lista[j] = lista[j + 1];
                                lista[j + 1] = AuxClient;
                            }
                        }
                    }
                    Singleton.Instance.listaClientes = lista;
                }
                else
                {
                    //ordenar por apellido
                    //Storage.Instance.clientList.Sort((x, y) => x.Apellido.CompareTo(y.Apellido));
                    for (int i = 0; i < lista.Count - 1; i++)
                    {
                        for (int j = 0; j < lista.Count - i - 1; j++)
                        {
                            if (CompararNombres(lista[j].apellidoC, lista[j + 1].apellidoC))
                            {
                                ClienteModelo AuxClient = lista[j];
                                lista[j] = lista[j + 1];
                                lista[j + 1] = AuxClient;
                            }
                        }
                    }
                    Singleton.Instance.listaClientes = lista;
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            //BubbleSort obtenido de https://www.geeksforgeeks.org/bubble-sort/
        }

        public bool CompararNombres(string nombre1, string nombre2)
        {
            int length;
            if (nombre1.Length > nombre2.Length)
            {
                length = nombre1.Length;
            }
            else
            {
                length = nombre2.Length;
            }

            
            for (int i = 0; i < length; i++)
            {
                if (i < nombre1.Length && i < nombre2.Length)
                {
                    if (nombre1[i].CompareTo(nombre2[i]) < 0)
                    {
                        return false;
                    }
                    else if (nombre1[i].CompareTo(nombre2[i]) == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if (i >= nombre1.Length)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
        //Comportamiento de CompareTo obtenido de: https://www.geeksforgeeks.org/c-sharp-char-compareto-method/

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
