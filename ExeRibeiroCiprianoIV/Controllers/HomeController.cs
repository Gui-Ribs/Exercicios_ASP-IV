using ExeRibeiroCiprianoIV.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeRibeiroCiprianoIV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClienteCadastrado(Cliente cliente)
        {
             return View(cliente);
        }

        public ActionResult CheckLogin(string Login)
        {
            var dbCliente = new Collection<string>
            {
               "Prático",
               "Heitor",
               "Cícero"
            };
            return Json(dbCliente.All(a => a.ToLower() != Login.ToLower()), JsonRequestBehavior.AllowGet);
        }

        public ActionResult CheckCPF(long CPF)
        {
            var dbCliente = new Collection<long>
            {
               11122233311,
               11122233312,
               11122233313
            };
            return Json(dbCliente.All(a => a != CPF), JsonRequestBehavior.AllowGet);
        }

    }
}