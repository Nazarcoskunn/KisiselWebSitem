using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication33333.Models.Siniflar;

namespace WebApplication33333.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Default

        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Anasayfas.ToList();
            return View(deger);
        }
        public PartialViewResult ikonlar()
        {
            var deger = c.ikonlars.ToList();
            return PartialView(deger);
        }
       
    }
}