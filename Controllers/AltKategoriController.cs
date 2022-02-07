using MVCTekrar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTekrar.Controllers
{
    public class AltKategoriController : Controller
    {
        // GET: AltKategori
        public ActionResult Index()
        {
            MVCTekrar.Models.MVCTekrarDataEntities db = new Models.MVCTekrarDataEntities();
            var model = db.AltKategori.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Giris()
        {   MVCTekrar.Models.AltKategori model = Model_Olustur();
            return View(model);
        }
        [HttpPost]
        public ActionResult Giris(AltKategori Ekranmodel)
        {
            try
            {
                MVCTekrar.Models.MVCTekrarDataEntities db = new MVCTekrarDataEntities();
                AltKategori VeriModel = new AltKategori();

                VeriModel.AltKategoriAdi = Ekranmodel.AltKategoriAdi;
                VeriModel.KategoriId = Ekranmodel.KategoriId;
                db.AltKategori.Add(VeriModel);
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                string Hata = ex.ToString();
            }
            finally
            {
                
            }
            return View();



        }

        private AltKategori Model_Olustur()
        {
            MVCTekrar.Models.MVCTekrarDataEntities db = new Models.MVCTekrarDataEntities();
            AltKategori model = new AltKategori();
            model.KategoriList = (from Kat in db.AnaKategori
                                  select new SelectListItem
                                  {
                                      Selected = false,
                                      Text = Kat.KategoriAdi,
                                      Value = Kat.KategoriId.ToString()
                                  }).ToList();
            model.KategoriList.Insert(0, new SelectListItem
            {
                Selected = true,
                Value = "",
                Text = "Seçiniz."
            });
            return model;
        } 
    }
}