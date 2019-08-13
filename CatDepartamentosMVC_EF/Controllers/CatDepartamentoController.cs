using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CatDepartamentosMVC_EF.Models;

namespace CatDepartamentosMVC_EF.Controllers
{
    public class CatDepartamentoController : Controller
    {
        private Ejemplo1Entities1 db = new Ejemplo1Entities1();

        // GET: CatDepartamento
        public ActionResult Index(string sortOrder, string searchString)
        {
            //IdOfiSortParm
            ViewBag.IdOfiSortParm = String.IsNullOrEmpty(sortOrder) ? "IdOfi" : "";
            ViewBag.DescripDeptoSortParm = String.IsNullOrEmpty(sortOrder) ? "Descrip_Depto" : "";
            ViewBag.DeptoActivoSortParm = String.IsNullOrEmpty(sortOrder) ? "Depto_Activo" : ""; 

            var departamentos = from d in db.CatDepartamento
                           select d;

            if (!String.IsNullOrEmpty(searchString))
            {
                departamentos = departamentos.Where(d => d.Depto_Descripcion.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "IdOfi":
                    departamentos = departamentos.OrderBy(d => d.Id_Ofi);
                break;

                case "Descrip_Depto":
                    departamentos = departamentos.OrderBy(d => d.Depto_Descripcion);
                break;

                case "Depto_Activo":
                    departamentos = departamentos.OrderByDescending(d => d.Depto_Activo);
                break;

                default:
                    departamentos = departamentos.OrderBy(d => d.Depto_Descripcion);
                break;
            }
            return View(departamentos.ToList());
        }

        // GET: CatDepartamento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatDepartamento catDepartamento = db.CatDepartamento.Find(id);
            if (catDepartamento == null)
            {
                return HttpNotFound();
            }
            return View(catDepartamento);
        }

        // GET: CatDepartamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatDepartamento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Ofi,Id_Depto,Depto_Descripcion,Depto_Activo")] CatDepartamento catDepartamento)
        {
            if (ModelState.IsValid)
            {
                db.CatDepartamento.Add(catDepartamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(catDepartamento);
        }

        // GET: CatDepartamento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatDepartamento catDepartamento = db.CatDepartamento.Find(id);
            if (catDepartamento == null)
            {
                return HttpNotFound();
            }
            return View(catDepartamento);
        }

        // POST: CatDepartamento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Ofi,Id_Depto,Depto_Descripcion,Depto_Activo")] CatDepartamento catDepartamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catDepartamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catDepartamento);
        }

        // GET: CatDepartamento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatDepartamento catDepartamento = db.CatDepartamento.Find(id);
            if (catDepartamento == null)
            {
                return HttpNotFound();
            }
            return View(catDepartamento);
        }

        // POST: CatDepartamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CatDepartamento catDepartamento = db.CatDepartamento.Find(id);
            db.CatDepartamento.Remove(catDepartamento);
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