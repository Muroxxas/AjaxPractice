using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxPractice.Models;
using AjaxPractice.Concrete;
using System.Data.Entity;
using System.Net;

namespace AjaxPractice.Controllers
{
    public class HomeController : Controller
    {

        private EFDBContext db;

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult test()
        {
            return PartialView("_Partial");
        }
    }
}

