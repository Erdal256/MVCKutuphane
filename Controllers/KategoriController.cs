using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCKutuphane.Models.Entity;
namespace MVCKutuphane.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        DBKUTUPHANEEntities1 db = new DBKUTUPHANEEntities1();
        public ActionResult Index()
        {
            var degerler = db.TBLKATEGORI.ToList();
            return View(degerler);
        }
        [HttpGet] //sayfa yüklendiğinde bu kısım çalışsın. başka bir şey yapmasın
        public ActionResult KategoriEkle()
        {
            return View();
        }

        //TBLKATEGORİDEN türediği için p parametresini ekledik.
        //kategorilerden Add View diyerek kategoriekle türettik.
        [HttpPost] // sayfa yülendiğinde bir kısıma tıkladığımızda çalışması için bu kısım çalışsın.
        public ActionResult KategoriEkle(TBLKATEGORI p) 
        {
            db.TBLKATEGORI.Add(p);//eklemek p den gelen degerleri ekle
            db.SaveChanges(); //değişiklikleri kaydet demek.
            return View(); //sayfayı bize geri döndürecektir.
        }
    }
}