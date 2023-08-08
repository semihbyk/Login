using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class AccountController : Controller
    {
        // GET: Hesap
        public ActionResult Login()
        {
            return View("Account/Login");
        }
        [HttpPost]

        public ActionResult Login(string kadi, string sifre)
        {
            if (kadi == "semih" && sifre =="baykara")
            {
                return RedirectToAction("Merhaba", "Anasayfa");
            }
            else
            {
                ViewBag.ErrorMessage = "Bilgilerinizi Kontrol Ediniz.";
                return View();
            }

            

        }
    }
}