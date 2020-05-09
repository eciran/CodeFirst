using mvcCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcCRUD.Controllers
{
    public class HomeController : Controller
    {
        OkulDB _db = new OkulDB();
        // GET: Home
        public ActionResult YeniOlustur()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Category c)
        {
            Category cat = new Category();
            cat.CategoryName = c.CategoryName;
			cat.CategoryDesc = c.CategoryDesc;

            _db.Categories.Add(cat);
            _db.SaveChanges();

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var ogrenciler = _db.Categories.ToList();
            return View(ogrenciler);
        }

		//    public ActionResult Delete(int id)
		//    {
		//        Ogrenci silinecekOgr = _db.Ogrenci.Find(id);
		//        _db.Ogrenci.Remove(silinecekOgr);
		//        _db.SaveChanges();

		//        return RedirectToAction("List");
		//    }

		//    public ActionResult Edit(int id)
		//    {
		//        Ogrenci duzenlenecekOgr = _db.Ogrenci.Find(id);
		//        return View(duzenlenecekOgr);
		//    }

		//    public ActionResult Duzenle(Ogrenci o)
		//    {
		//        Ogrenci ogr = _db.Ogrenci.Find(o.ID);

		//        ogr.Name = o.Name;
		//        ogr.Surname = o.Surname;
		//        ogr.Age = o.Age;
		//        ogr.Grade = o.Grade;
		//        _db.SaveChanges();
		//        return RedirectToAction("List");
		//    }
	}
}