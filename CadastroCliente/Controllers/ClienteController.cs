using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using CadastroCliente.Data;
using CadastroCliente.Models;
using CadastroCliente.ViewModel;

namespace CadastroCliente.Controllers
{
    public class ClienteController : Controller
    {
        private HomeContext db = new HomeContext();

        // GET: Cliente
        public ActionResult Index()
        {
            return View(db.Clientes.ToList());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteModel clienteModel = db.Clientes.Find(id);
            if (clienteModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteModel);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CadastroCliViewModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Clientes.Add(clienteModel.Cliente);
                    db.Enderecos.Add(clienteModel.Endereco);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return View(clienteModel);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteModel clienteModel = db.Clientes.Find(id);
            if (clienteModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteModel);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCliente,Nome,DataNascimento,Sexo,IdEndereco,CEP,Logradouro,Complemento,Bairro,Estado,Cidade,Numero")] ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clienteModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clienteModel);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteModel clienteModel = db.Clientes.Find(id);
            if (clienteModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClienteModel clienteModel = db.Clientes.Find(id);
            db.Clientes.Remove(clienteModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
