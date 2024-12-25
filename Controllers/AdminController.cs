using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication33333.Models.Siniflar;

namespace WebApplication33333.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.Anasayfas.ToList();
            return View(deger);
        }
        public ActionResult AnasayfaGetir(int id)
        {
            var ag = c.Anasayfas.Find(id);
            return View("AnaSayfaGetir", ag);
        }
        public ActionResult AnaSayfaGuncelle(Anasayfa x)
        {
        var ag= c.Anasayfas.Find(x.id);
        ag.isim=x.isim;
        ag.profil=x.profil;
        ag.unvan=x.unvan;
        ag.aciklama=x.aciklama;
        ag.iletisim=x.iletisim;
        c.SaveChanges();
        return RedirectToAction("index");
       }

        public ActionResult İkonListesi() {

            var deger = c.ikonlars.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniIkon(ikonlar p)
        {
            c.ikonlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }

        public ActionResult ikonGetir(int id)
        {
            var ig = c.ikonlars.Find(id);
            return View("ikonGetir", ig);
        }

        public ActionResult ikonGuncelle(ikonlar x)
        {
            var ig = c.ikonlars.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }

        public ActionResult ikonSil(int id)
        {
            var sl = c.ikonlars.Find(id);
            c.ikonlars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }


    }
}
