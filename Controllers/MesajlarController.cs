using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCKutuphane.Models.Entity;

namespace MVCKutuphane.Controllers
{
    public class MesajlarController : Controller
    {
        // GET: Mesajlar
        DBKUTUPHANEEntities1 db = new DBKUTUPHANEEntities1();
        public ActionResult Index()
        {
            //var uyemail = (string)Session["Mail"].ToString();
            var mesajlar = db.TBLMESAJLAR./*Where(x => x.ALICI == uyemail.ToString()).*/ToList(); ;
            return View(mesajlar);
        }
        public ActionResult YeniMesaj()
        {
            return View();
        }
    }
}