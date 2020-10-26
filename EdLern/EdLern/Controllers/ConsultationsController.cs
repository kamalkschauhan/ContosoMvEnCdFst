using EdLern.DAL;
using EdLern.Models;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EdLern.Controllers
{
    public class ConsultationsController : Controller
    {
        private readonly SchoolContext db = new SchoolContext();

        // GET: Consultations
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await db.Consultations.ToListAsync().ConfigureAwait(false));
        }

        // GET: Consultations/Details/5
        [HttpGet]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultation consultation = await db.Consultations.FindAsync(id).ConfigureAwait(false);
            if (consultation == null)
            {
                return HttpNotFound();
            }
            return View(consultation);
        }

        // GET: Consultations/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consultations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,ConsultationName,ConsultationDescription,IsActive")] Consultation consultation)
        {
            if (ModelState.IsValid)
            {
                db.Consultations.Add(consultation);
                await db.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction("Index");
            }

            return View(consultation);
        }

        // GET: Consultations/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultation consultation = await db.Consultations.FindAsync(id).ConfigureAwait(false);
            if (consultation == null)
            {
                return HttpNotFound();
            }
            return View(consultation);
        }

        // POST: Consultations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,ConsultationName,ConsultationDescription,IsActive")] Consultation consultation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultation).State = EntityState.Modified;
                await db.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction("Index");
            }
            return View(consultation);
        }

        // GET: Consultations/Delete/5
        [HttpGet]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultation consultation = await db.Consultations.FindAsync(id).ConfigureAwait(false);
            if (consultation == null)
            {
                return HttpNotFound();
            }
            return View(consultation);
        }

        // POST: Consultations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Consultation consultation = await db.Consultations.FindAsync(id).ConfigureAwait(false);
            db.Consultations.Remove(consultation);
            await db.SaveChangesAsync().ConfigureAwait(false);
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
