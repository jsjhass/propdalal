using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Propdalal.Models;

namespace Propdalal.Controllers
{
    public class PropertylistController : Controller
    {
        private HousingModel db = new HousingModel();
        // GET: Propertylist
        public ActionResult Index()
        {
            string rentsale = Request.Form["Rentsale"];
            string proptype = Request.Form["Proptype"];
            string location = Request.Form["Location"];
            int rentsaleid = Convert.ToInt32(db.RentSales.Where(m => m.Name == rentsale).Select(m => m.Id).Single());
            int proptypeid = Convert.ToInt32(db.PropertyTypes.Where(m => m.Name == proptype).Select(m => m.Id).Single());
            int locationid =Convert.ToInt32(db.LocationAreas.Where(m => m.Name == location).Select(m => m.Id).Single());
            var property = db.Projects.Where(m=>m.RentSaleID==rentsaleid && m.PropertyTypeID==proptypeid && m.LocationAreaID == locationid);
            return View(property);
        }
        public ActionResult Submitsale()
        {
            var location = db.LocationAreas.Select(m => new SelectListItem { Text = m.Name, Value = m.Name });
            ViewBag.Location = location.ToList();
            var prop = db.PropertyTypes.Select(m => new SelectListItem { Text = m.Name, Value = m.Name });
            ViewBag.Proptype = prop.ToList();
            var rentsale = db.RentSales.Select(m => new SelectListItem { Text = m.Name, Value = m.Name });
            ViewBag.Rentsale = rentsale.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Submitsale(Project pr)
        {
            string rentsale = Request.Form["Rentsale"];
            string proptype = Request.Form["Proptype"];
            string location = Request.Form["Location"];
            int rentsaleid = Convert.ToInt32(db.RentSales.Where(m => m.Name == rentsale).Select(m => m.Id).Single());
            int proptypeid = Convert.ToInt32(db.PropertyTypes.Where(m => m.Name == proptype).Select(m => m.Id).Single());
            int locationid = Convert.ToInt32(db.LocationAreas.Where(m => m.Name == location).Select(m => m.Id).Single());
            pr.RentSaleID = rentsaleid;
            pr.PropertyTypeID = proptypeid;
            pr.LocationAreaID = locationid;
            db.Projects.Add(pr);
            db.SaveChanges();
            TempData["Submitsale"] = "Submit successfully.";
            return RedirectToAction("Submitsale");
        }
    }
}