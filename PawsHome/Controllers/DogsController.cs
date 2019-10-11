using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PawsHome.Models;

namespace PawsHome.Controllers
{
    public class DogsController : Controller
    {
        private NewModel db = new NewModel();

        //budget
        public ActionResult Budget(int? id)
        {
            ViewBag.Breeds = new SelectList(db.Dogs, "id", "breed");
            if (id == null)
            {
                ViewData["selected"] = -1;
            }
            else {
                ViewData["selected"] = id;
            }
            return View(db.Dogs.ToList());
        }

        //report
        public ActionResult Report()
        {
            ViewBag.Breeds = new SelectList(db.Dogs,"id","breed");
            return View(db.Dogs.ToList());
        }

        // GET: Dogs
        public ActionResult Index()
        {
            return View(db.Dogs.ToList());
        }

        // GET: Dogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dog dog = db.Dogs.Find(id);
            if (dog == null)
            {
                return HttpNotFound();
            }
            return View(dog);
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
