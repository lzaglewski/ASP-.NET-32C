using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobilePost_Service.Models;

namespace MobilePost_Service.Controllers
{
    public class ParcelController : Controller
    {
        private ParcelContext _db;
        public ParcelController()
        {
            _db = new ParcelContext();
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Witaj w serwisie MobilePost";
            return View();
        }
        public ActionResult List()
        {
            var parcels = _db.Parcels;
            return View(parcels);
         }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Parcel model){
            if (ModelState.IsValid)
            {
                model.RegistationDate = DateTime.Now;
                _db.Parcels.Add(model);
                _db.SaveChanges();
                TempData["Message"] = "Zgloszenie zotsalo zarejestrowane.";
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
