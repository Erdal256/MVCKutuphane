using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCKutuphane.Models.Entity;
namespace MVCKutuphane.Controllers
{
    public class IslemController : Controller
    {
        // GET: Islem
        DBKUTUPHANEEntities1 db = new DBKUTUPHANEEntities1();
        public ActionResult Index()
        {
            var degerler = db.TBLHAREKET.Where(x => x.ISLEMDURUM == true).ToList();
            return View(degerler);
        }
    }
}