using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EdLern.DAL;
using EdLern.Models;

namespace EdLern.Controllers
{
    public class ProgramsController : Controller
    {
        private readonly SchoolContext db = new SchoolContext();

        // GET: Programs
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await db.Programs.ToListAsync().ConfigureAwait(false));
        }

        // GET: Programs/Details/5
        [HttpGet]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Program program = await db.Programs.FindAsync(id).ConfigureAwait(false);
            if (program == null)
            {
                return HttpNotFound();
            }
            return View(program);
        }

        // GET: Programs/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Programs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,ProgramName,ProgramDescription,IsActive")] Program program)
        {
            if (ModelState.IsValid)
            {
                db.Programs.Add(program);
                await db.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction("Index");
            }

            return View(program);
        }

        // GET: Programs/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Program program = await db.Programs.FindAsync(id).ConfigureAwait(false);
            if (program == null)
            {
                return HttpNotFound();
            }
            return View(program);
        }

        // POST: Programs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,ProgramName,ProgramDescription,IsActive")] Program program)
        {
            if (ModelState.IsValid)
            {
                db.Entry(program).State = EntityState.Modified;
                await db.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction("Index");
            }
            return View(program);
        }

        // GET: Programs/Delete/5
        [HttpGet]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Program program = await db.Programs.FindAsync(id).ConfigureAwait(false);
            if (program == null)
            {
                return HttpNotFound();
            }
            return View(program);
        }

        // POST: Programs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Program program = await db.Programs.FindAsync(id).ConfigureAwait(false);
            db.Programs.Remove(program);
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
