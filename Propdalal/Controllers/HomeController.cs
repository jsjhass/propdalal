using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Propdalal.Models;

namespace Propdalal.Controllers
{
    public class HomeController : Controller
    {
        private HousingModel db = new HousingModel();
        public ActionResult Index()
        {
            ViewBag.home = "Home";
            var location = db.LocationAreas.Select(m => new SelectListItem { Text = m.Name, Value = m.Name });
            ViewBag.Location = location.ToList();
            var prop = db.PropertyTypes.Select(m => new SelectListItem { Text = m.Name, Value = m.Name });
            ViewBag.Proptype = prop.ToList();
            var rentsale = db.RentSales.Select(m => new SelectListItem { Text = m.Name, Value = m.Name });
            ViewBag.Rentsale = rentsale.ToList();
            return View();
        }

        public ActionResult About()
        {
           
            return View();
        }

        public ActionResult Contact()
        {
           
            return View();
        }
    }
}