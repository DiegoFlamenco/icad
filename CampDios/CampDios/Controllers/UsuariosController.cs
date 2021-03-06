﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CampDios.Modelos;

namespace CampDios.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private CampDiosEntities db = new CampDiosEntities();

        // GET: Usuarios
        [AuthorizeUserAccesLevel(UserRole = true, Vista = "Administrador", Permiso = "Lectura")]
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        // GET: Usuarios/Details/5
        [AuthorizeUserAccesLevel(UserRole = true, Vista = "Administrador", Permiso = "Lectura")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = db.Usuarios.Find(id);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

        // GET: Usuarios/Create
        [AuthorizeUserAccesLevel(UserRole = true, Vista = "Administrador", Permiso = "Escritura")]
        public ActionResult Create()
        {
            ViewBag.Miembro_Id = new SelectList(db.Miembros, "IdMiembro", "Nombres");
            return View();
        }

        // POST: Usuarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Usuarios_id,Login,Contraseña,Fecha_creacion,Miembro_id")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Miembro_Id = new SelectList(db.Miembros, "IdMiembro", "Nombres", usuarios.Miembro_id);
            return View(usuarios);
        }

        // GET: Usuarios/Edit/5
        [AuthorizeUserAccesLevel(UserRole = true, Vista = "Administrador", Permiso = "Edicion")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = db.Usuarios.Find(id);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            ViewBag.Miembro_Id = new SelectList(db.Miembros, "IdMiembro", "Nombres");
            return View(usuarios);
        }

        // POST: Usuarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Usuarios_id,Login,Contraseña,Fecha_creacion,Miembro_id")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Miembro_Id = new SelectList(db.Miembros, "IdMiembro", "Nombres", usuarios.Miembro_id);
            return View(usuarios);
        }

        // GET: Usuarios/Delete/
        [AuthorizeUserAccesLevel(UserRole = true, Vista = "Administrador", Permiso = "Edicion")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = db.Usuarios.Find(id);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuarios usuarios = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuarios);
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
