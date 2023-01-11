using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenzia.Controllers
{
    public class PersonaleController : Controller
    {
        // GET: Personale
        public ActionResult SignIn()
        {
            return View();
        }
    }
}