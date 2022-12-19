using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebKamp.Models;

namespace WebKamp.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Contact()
        {
            using(var context = new KAMPSEntities())
            {
                var userInfo = context.Kamp.ToList();
                return View(userInfo);
            }
            
        }
       
    }
}