using Agenzia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Agenzia.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult SignIn()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult SignIn(Utente U)
        //{
        //    if (Utente.Autenticato(U.Username, U.Password))
        //    {
        //        FormsAuthentication.SetAuthCookie(U.Username, false);
        //        return Redirect(FormsAuthentication.DefaultUrl);
        //    }
        //    ViewBag.messaggio = "Username e/o Password errati";
        //    return View();
        //}
    }
}