﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenzia.Controllers
{
    [Authorize]
    public class SpedizioniController : Controller
    {
        // GET: Spedizioni
        public ActionResult Index()
        {
            return View();
        }
    }
}