using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CadastroCliente.Data;
using CadastroCliente.Models;

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
        public ActionResult Create([Bind(Include = "IdCliente,Nome,DataNascimento,Sexo,CEP,Logradouro,Complemento,Bairro,Estado,Cidade,Numero")] ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(clienteModel);
                db.SaveChanges();
                return RedirectToAction("Index");
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
        public ActionResult Edit(ClienteModel clienteModel)
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
        public async Task<ActionResult> Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var livro = await db.Clientes.FindAsync(id);
            db.Clientes.Remove(livro);            
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

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
