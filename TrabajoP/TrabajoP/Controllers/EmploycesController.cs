using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TrabajoP.Models;

namespace TrabajoP.Controllers
{
    public class EmploycesController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Employces
        public ActionResult Index()
        {
            return View(db.Employces.ToList());
        }

        // GET: Employces/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employce employce = db.Employces.Find(id);
            if (employce == null)
            {
                return HttpNotFound();
            }
            return View(employce);
        }

        // GET: Employces/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employces/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Birthday,Salary")] Employce employce)
        {
            if (ModelState.IsValid)
            {
                db.Employces.Add(employce);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employce);
        }

        // GET: Employces/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employce employce = db.Employces.Find(id);
            if (employce == null)
            {
                return HttpNotFound();
            }
            return View(employce);
        }

        // POST: Employces/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Birthday,Salary")] Employce employce)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employce).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employce);
        }

        // GET: Employces/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employce employce = db.Employces.Find(id);
            if (employce == null)
            {
                return HttpNotFound();
            }
            return View(employce);
        }

        // POST: Employces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employce employce = db.Employces.Find(id);
            db.Employces.Remove(employce);
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
