using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

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

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //What if we manually override the Quote amount here rather than the user entering something?
                insuree.Quote = QuoteCalculation(insuree);
                //Success! THAT MEANS WE CAN RUN A FUNCTION HERE THAT WILL RETURN THE QUOTE VALUE
                //Phew... I was worried how this would work
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
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

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
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

        // POST: Insuree/Delete/5
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

        private decimal QuoteCalculation(Insuree insuree)
        {
            decimal quoteValue;
            quoteValue = 50;

            //First we check the insuree's age and raise the quoteValue accordingly
            if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18)
            {
                quoteValue += 100;
            }
            else if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 25)
            {
                quoteValue += 50;
            }
            else
            {
                quoteValue += 25;
            }

            //Now we check if the car is older than 2000 or newer than 2015
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                quoteValue += 25;
            }

            //First we check if the Car Make is a Porsche. If so, we add 25 to the quote.
            if (insuree.CarMake.ToUpper() == "PORSCHE")
            {
                quoteValue += 25;

                //If the make is Porsche and the model is 911 Carrera, we add an additional 25
                if (insuree.CarModel.ToUpper() == "911 CARRERA")
                {
                    quoteValue += 25;
                }
            }

            //Next, we add $10 for how many speeding tickets the insuree has.
            quoteValue += (insuree.SpeedingTickets * 10);

            //Then, we check for a DUI and increase the price by 25%
            if (insuree.DUI)
            {
                quoteValue *= 1.25m;
            }

            //Finally, we check if it's full coverage, multiplying by 1.5 if so
            if (insuree.CoverageType)
            {
                quoteValue *= 1.5m;
            }

            //After all the calculations, the quoteValue is returned.
            return quoteValue;
        }

        public ActionResult Admin()
        {
            //First we grab all our dB entries in a list
            var dbEntries = db.Insurees.ToList();
            //Then we create a list of our ViewModel
            var dbEntriesVM = new List<InsureeVM>();
            //Then we loop through all entries in our initial list, passing the 
            //relevant values to our ViewModel!
            foreach (Insuree dbEntry in dbEntries)
            {
                var dbEntryVM = new InsureeVM();
                dbEntryVM.FirstName = dbEntry.FirstName;
                dbEntryVM.LastName = dbEntry.LastName;
                dbEntryVM.EmailAddress = dbEntry.EmailAddress;
                dbEntryVM.Quote = dbEntry.Quote;
                dbEntriesVM.Add(dbEntryVM);
            }
            //Hopefully this works...


            return View(dbEntriesVM);
        }
    }
}
