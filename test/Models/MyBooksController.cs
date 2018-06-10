using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookManagmentMVC.Models;

namespace test.Models
{
    public class MyBooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MyBooks
        public async Task<ActionResult> Index()
        {
            return View(await db.MyBooks.ToListAsync());
        }

        // GET: MyBooks/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyBook myBook = await db.MyBooks.FindAsync(id);
            if (myBook == null)
            {
                return HttpNotFound();
            }
            return View(myBook);
        }

        // GET: MyBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyBooks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,BookName,AuthorName,BookPrice,BookPublish,Comments")] MyBook myBook)
        {
            if (ModelState.IsValid)
            {
                db.MyBooks.Add(myBook);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(myBook);
        }

        // GET: MyBooks/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyBook myBook = await db.MyBooks.FindAsync(id);
            if (myBook == null)
            {
                return HttpNotFound();
            }
            return View(myBook);
        }

        // POST: MyBooks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,BookName,AuthorName,BookPrice,BookPublish,Comments")] MyBook myBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myBook).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(myBook);
        }

        // GET: MyBooks/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyBook myBook = await db.MyBooks.FindAsync(id);
            if (myBook == null)
            {
                return HttpNotFound();
            }
            return View(myBook);
        }

        // POST: MyBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MyBook myBook = await db.MyBooks.FindAsync(id);
            db.MyBooks.Remove(myBook);
            await db.SaveChangesAsync();
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
