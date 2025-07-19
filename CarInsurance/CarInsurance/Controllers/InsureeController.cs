﻿using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Calculate quote before saving
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return View("~/Views/Home/Success.cshtml");
            }
            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Recalculate quote before saving changes
                insuree.Quote = CalculateQuote(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        private decimal CalculateQuote(Insuree insuree)
        {
            decimal baseQuote = 50m; // Standard base rate

            // Calculate age accurately
            var today = DateTime.Today;
            int age = today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth > today.AddYears(-age)) age--;

            // Apply age-based premiums
            if (age <= 18) baseQuote += 100m;
            else if (age >= 19 && age <= 25) baseQuote += 50m;
            else baseQuote += 25m;

            // Apply vehicle year adjustments
            if (insuree.CarYear < 2000) baseQuote += 25m;
            else if (insuree.CarYear > 2015) baseQuote += 25m;

            // Apply make/model adjustments
            if (insuree.CarMake?.ToUpper() == "PORSCHE")
            {
                baseQuote += (insuree.CarModel?.ToUpper() == "911 CARRERA")
                    ? 50m : 25m;
            }

            // Apply speeding ticket charges
            baseQuote += insuree.SpeedingTickets * 10m;

            // Apply risk multipliers
            if (insuree.DUI) baseQuote *= 1.25m;
            if (insuree.CoverageType) baseQuote *= 1.5m;

            return baseQuote;
        }
    }
}