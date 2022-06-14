using Point_of_sale.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Point_of_sale.Controllers
{
    [Authorize]
    public class BarangController : Controller
    {
        // GET: Barang
        public ActionResult Barang()
        {
            List<Barang> r;
            using (var s = new market_posEntities_())
            {
                r = s.Barang.ToList();
            }
            return View(r);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            var barangmodel = new Barang();
            TryUpdateModel(barangmodel);

            using (var s = new  market_posEntities_())
            {
                s.Barang.Add(barangmodel);
                s.SaveChanges();
            }

            return RedirectToAction("Barang");
        }

        [HttpGet]
        public ActionResult Details(string idbarang)
        {
            var barangmodel = new Barang();
            TryUpdateModel(barangmodel);

            using (var s = new market_posEntities_())
            {
                barangmodel = s.Barang.FirstOrDefault(x => x.IDBarang == idbarang);
            }
            return View(barangmodel);
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(string idbarang)
        {
            var barangmodel = new Barang();
            TryUpdateModel(barangmodel);
            using (var s = new market_posEntities_())
            {
                barangmodel = s.Barang.Where(x => x.IDBarang == idbarang).FirstOrDefault();
            }
            return View(barangmodel);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(string idbarang)
        {
            var barangmodel = new Barang();
            TryUpdateModel(barangmodel);
            using (var s = new market_posEntities_())
            {
                var m = s.Barang.Where(x => x.IDBarang == idbarang).FirstOrDefault();
                TryUpdateModel(m);
                s.SaveChanges();
            }
            return RedirectToAction("Barang");
        }

        [HttpGet]
        [ActionName("Delete")]
        public ActionResult Delete_Get(string idbarang)
        {
            var barangmodel = new Barang();
            TryUpdateModel(barangmodel);

            using (var r = new market_posEntities_())
            {
                barangmodel = r.Barang.FirstOrDefault(x => x.IDBarang == idbarang);
            }

            return View(barangmodel);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post(string idbarang)
        {
            var barangmodel = new market_posEntities_();
            TryUpdateModel(barangmodel);
            using (var s = new market_posEntities_())
            {
                var m = s.Barang.Remove(s.Barang.FirstOrDefault(x => x.IDBarang == idbarang));
                TryUpdateModel(m);
                s.SaveChanges();
            }
            return RedirectToAction("Barang");
        }


    }
}