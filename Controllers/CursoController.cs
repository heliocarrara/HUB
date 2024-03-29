﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HUB.Controllers
{
    public class CursoController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "Home");
        }

        public ActionResult CursosDisponiveis()
        {
            try
            {
                return View();
            }
            catch(Exception ex)
            {
                return Index();
            }
        }

        public ActionResult Detalhes(int? id)
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return CursosDisponiveis();
            }
        }
    }
}