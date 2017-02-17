using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Propdalal.Models;

namespace Propdalal.Controllers
{
    public class RentdetailController : Controller
    {
        private HousingModel db = new HousingModel();
        // GET: Rentdetail
        public ActionResult Index()
        {
            var rent = db.Projects.Where(m => m.RentSaleID == 1);
            return View(rent);
        }
    }
}