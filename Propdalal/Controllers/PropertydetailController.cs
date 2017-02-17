using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Propdalal.Models;

namespace Propdalal.Controllers
{
    public class PropertydetailController : Controller
    {
        private HousingModel db = new HousingModel();
        // GET: Propertydetail
        public ActionResult Index(int? id)
        {
            var detail = db.Projects.Find(id);
            return PartialView(detail); 
        }
    }
}