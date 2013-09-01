using System.Data;
using System.Linq;
using System.Web.Mvc;
using VirtualAssistant.Web.Models;
using VirtualAssistant.Web.Models.VirtualAssistant;

namespace VirtualAssistant.Web.Controllers
{
    public class UserTaskController : Controller
    {
        private UserTaskContext db = new UserTaskContext();

        //
        // GET: /UserTask/

        public ActionResult Index()
        {
            return View(db.UserTaskModels.ToList());
        }

        //
        // GET: /UserTask/Details/5

        public ActionResult Details(int id = 0)
        {
            UserTaskModel usertaskmodel = db.UserTaskModels.Find(id);
            if (usertaskmodel == null)
            {
                return HttpNotFound();
            }
            return View(usertaskmodel);
        }

        //
        // GET: /UserTask/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UserTask/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserTaskModel usertaskmodel)
        {
            if (ModelState.IsValid)
            {
                db.UserTaskModels.Add(usertaskmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usertaskmodel);
        }

        //
        // GET: /UserTask/Edit/5

        public ActionResult Edit(int id = 0)
        {
            UserTaskModel usertaskmodel = db.UserTaskModels.Find(id);
            if (usertaskmodel == null)
            {
                return HttpNotFound();
            }
            return View(usertaskmodel);
        }

        //
        // POST: /UserTask/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserTaskModel usertaskmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usertaskmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usertaskmodel);
        }

        //
        // GET: /UserTask/Delete/5

        public ActionResult Delete(int id = 0)
        {
            UserTaskModel usertaskmodel = db.UserTaskModels.Find(id);
            if (usertaskmodel == null)
            {
                return HttpNotFound();
            }
            return View(usertaskmodel);
        }

        //
        // POST: /UserTask/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserTaskModel usertaskmodel = db.UserTaskModels.Find(id);
            db.UserTaskModels.Remove(usertaskmodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}