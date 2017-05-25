﻿using SmallRoadWeb.DAL;
using SmallRoadWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Services;

namespace SmallRoadWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private static bool logado;

        public static bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }

        public string LogadoSession
        {
            get { return Session["Logado"].ToString(); }
            set { Session["Logado"] = value; }
        }

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[WebMethod(EnableSession = true)]
        public bool Logar(Usuario usuario)
        {
            //System.Web.HttpContext.Current.Session["Logado"] = "true";
            UsuarioDal usuarioDal = new UsuarioDal();
            return usuarioDal.Logar(usuario);
        }
    }
}