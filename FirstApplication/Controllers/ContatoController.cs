using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplication.Models;

namespace FirstApplication.Controllers
{
    public class ContatoController : Controller
    {
        //
        // GET: /Contato

        public ActionResult Index()
        {
            Contato C = new Contato() { Nome = "Curso MVC", Telefone = "123123123", HorarioComercial = true };
            //return View(C);
            return this.Redirect("http://google.com");
        }

    }
}
