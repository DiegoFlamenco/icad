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
    public class PastoresController : Controller
    {
        private CampDiosEntities db = new CampDiosEntities();

        // GET: Pastores
        //[AuthorizeUserAccesLevel(UserRole = "user")]
        public ActionResult Index()
        {
            var pastores = db.Pastores.Include(p => p.Capacitaciones).Include(p => p.EstadoCivil).Include(p => p.Iglesia1).Include(p => p.LiderazgoCorporativo).Include(p => p.Pastores2).Include(p => p.Profesion).Include(p => p.RolesPastor).Include(p => p.Sexo1);
            return View(pastores.ToList());
        }

        // GET: Pastores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pastores pastores = db.Pastores.Find(id);
            if (pastores == null)
            {
                return HttpNotFound();
            }
            return View(pastores);
        }

        // GET: Pastores/Create
        public ActionResult Create()
        {
            ViewBag.IdCapacitacion = new SelectList(db.Capacitaciones, "IdCapacitacion", "Nombre");
            ViewBag.IdEstadoCivil = new SelectList(db.EstadoCivil, "IdEstado", "Estado");
            ViewBag.IdIglesia = new SelectList(db.Iglesia, "IdIglesia", "Nombre");
            ViewBag.IdCorporativo = new SelectList(db.LiderazgoCorporativo, "IdCorporativo", "Nombre");
            ViewBag.IdHMayor = new SelectList(db.Pastores, "IdPastor", "Nombres");
            ViewBag.IdProfesion = new SelectList(db.Profesion, "IdProfesion", "Oficio");
            ViewBag.IdRolPastor = new SelectList(db.RolesPastor, "IdRolPastor", "RolPastor");
            ViewBag.Sexo = new SelectList(db.Sexo, "IdSexo", "Sexo1");
            return View();
        }

        // POST: Pastores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPastor,Nombres,Apellidos,DUI,NIT,FechaNacimiento,Direccion,Direccion1,Direccion2,Email,Tel,Cel,Sexo,IdEstadoCivil,IdProfesion,IdCapacitacion,IdRolPastor,IdHMayor,IdCorporativo,IdIglesia")] Pastores pastores)
        {
            if (ModelState.IsValid)
            {
                db.Pastores.Add(pastores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCapacitacion = new SelectList(db.Capacitaciones, "IdCapacitacion", "Nombre", pastores.IdCapacitacion);
            ViewBag.IdEstadoCivil = new SelectList(db.EstadoCivil, "IdEstado", "Estado", pastores.IdEstadoCivil);
            ViewBag.IdIglesia = new SelectList(db.Iglesia, "IdIglesia", "Nombre", pastores.IdIglesia);
            ViewBag.IdCorporativo = new SelectList(db.LiderazgoCorporativo, "IdCorporativo", "Nombre", pastores.IdCorporativo);
            ViewBag.IdHMayor = new SelectList(db.Pastores, "IdPastor", "Nombres", pastores.IdHMayor);
            ViewBag.IdProfesion = new SelectList(db.Profesion, "IdProfesion", "Oficio", pastores.IdProfesion);
            ViewBag.IdRolPastor = new SelectList(db.RolesPastor, "IdRolPastor", "RolPastor", pastores.IdRolPastor);
            ViewBag.Sexo = new SelectList(db.Sexo, "IdSexo", "Sexo1", pastores.Sexo);
            return View(pastores);
        }

        // GET: Pastores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pastores pastores = db.Pastores.Find(id);
            if (pastores == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCapacitacion = new SelectList(db.Capacitaciones, "IdCapacitacion", "Nombre", pastores.IdCapacitacion);
            ViewBag.IdEstadoCivil = new SelectList(db.EstadoCivil, "IdEstado", "Estado", pastores.IdEstadoCivil);
            ViewBag.IdIglesia = new SelectList(db.Iglesia, "IdIglesia", "Nombre", pastores.IdIglesia);
            ViewBag.IdCorporativo = new SelectList(db.LiderazgoCorporativo, "IdCorporativo", "Nombre", pastores.IdCorporativo);
            ViewBag.IdHMayor = new SelectList(db.Pastores, "IdPastor", "Nombres", pastores.IdHMayor);
            ViewBag.IdProfesion = new SelectList(db.Profesion, "IdProfesion", "Oficio", pastores.IdProfesion);
            ViewBag.IdRolPastor = new SelectList(db.RolesPastor, "IdRolPastor", "RolPastor", pastores.IdRolPastor);
            ViewBag.Sexo = new SelectList(db.Sexo, "IdSexo", "Sexo1", pastores.Sexo);
            return View(pastores);
        }

        // POST: Pastores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPastor,Nombres,Apellidos,DUI,NIT,FechaNacimiento,Direccion,Direccion1,Direccion2,Email,Tel,Cel,Sexo,IdEstadoCivil,IdProfesion,IdCapacitacion,IdRolPastor,IdHMayor,IdCorporativo,IdIglesia")] Pastores pastores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pastores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCapacitacion = new SelectList(db.Capacitaciones, "IdCapacitacion", "Nombre", pastores.IdCapacitacion);
            ViewBag.IdEstadoCivil = new SelectList(db.EstadoCivil, "IdEstado", "Estado", pastores.IdEstadoCivil);
            ViewBag.IdIglesia = new SelectList(db.Iglesia, "IdIglesia", "Nombre", pastores.IdIglesia);
            ViewBag.IdCorporativo = new SelectList(db.LiderazgoCorporativo, "IdCorporativo", "Nombre", pastores.IdCorporativo);
            ViewBag.IdHMayor = new SelectList(db.Pastores, "IdPastor", "Nombres", pastores.IdHMayor);
            ViewBag.IdProfesion = new SelectList(db.Profesion, "IdProfesion", "Oficio", pastores.IdProfesion);
            ViewBag.IdRolPastor = new SelectList(db.RolesPastor, "IdRolPastor", "RolPastor", pastores.IdRolPastor);
            ViewBag.Sexo = new SelectList(db.Sexo, "IdSexo", "Sexo1", pastores.Sexo);
            return View(pastores);
        }

        // GET: Pastores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pastores pastores = db.Pastores.Find(id);
            if (pastores == null)
            {
                return HttpNotFound();
            }
            return View(pastores);
        }

        // POST: Pastores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pastores pastores = db.Pastores.Find(id);
            db.Pastores.Remove(pastores);
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
