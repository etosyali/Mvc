using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTekrar.Controllers
{
    public class AnaKategoriController : Controller
    {
        // GET: AnaKategori
        public ActionResult Index()
        {
            MVCTekrar.Models.MVCTekrarDataEntities db = new Models.MVCTekrarDataEntities();
            var model = db.AnaKategori.ToList();
            return View(model);
        }
    }
}