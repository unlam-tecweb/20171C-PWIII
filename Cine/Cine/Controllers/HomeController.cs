﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cine.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registracion()
        {
            return View();
        }

    }
}
