using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebKamp.Models;
using System.Data.SqlClient;
using System.Web.Security;

namespace WebKamp.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            KAMPSEntities db = new KAMPSEntities();
            Kamp model = new Kamp();
            model.İsim = form["isim"].Trim();
            model.Soyisim = form["soyisim"].Trim();
            model.Tc = form["kimlik"].Trim();
            model.DoğumTarihi = form["doğumgünü"].Trim();
            model.Telefon = form["telefon"].Trim();
            model.Mail = form["mail"].Trim();
            model.Fotoğraf = form["foto+"].Trim();
            db.Kamp.Add(model);
            db.SaveChanges();
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(AdminKamp adminFormu)
        {
            using(KAMPSEntities db = new KAMPSEntities())
            {
                var kullaniciCheck = db.AdminKamp.FirstOrDefault(
                    x=>x.KullanıcıAdı==adminFormu.KullanıcıAdı && x.Şifre == adminFormu.Şifre);

                if(kullaniciCheck != null)
                {
                    FormsAuthentication.SetAuthCookie(kullaniciCheck.KullanıcıAdı, false);

                    return RedirectToAction("/Contact", "Form");
                }
                ViewBag.Mesaj = "Kullanıcı adı veya şifre hatalı!";
                return View();
            }
           
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("About");
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Cont()
        {
            return View();
        }

    }
}