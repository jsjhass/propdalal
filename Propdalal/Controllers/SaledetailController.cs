using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Propdalal.Models;

namespace Propdalal.Controllers
{
    public class SaledetailController : Controller
    {
        private HousingModel db = new HousingModel();
        // GET: Saledetail
        public ActionResult Index()
        {
            var sale = db.Projects.Where(m => m.RentSaleID == 2);
            return View(sale);
        }
    }
}