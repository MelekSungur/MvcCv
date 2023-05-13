using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities1 db = new DbCvEntities1();
        public ActionResult Index()
        {
            var degerler=db.TblHakkimda.ToList();

            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler=db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }
      public PartialViewResult Egitim()
        {
            var egitim = db.TblEgitimlerim.ToList();
            return PartialView(egitim);

        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenek = db.TblYeteneklerim.ToList();
            return PartialView(yetenek);

        }
        public PartialViewResult Hobilerim()
        {
            var hobi = db.TblHobilerim.ToList();
            return PartialView(hobi);

        }
    }
}