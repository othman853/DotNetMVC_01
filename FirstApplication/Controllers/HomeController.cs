﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            @ViewBag.Agora = DateTime.Now;
            return View();
        }

    }
}
