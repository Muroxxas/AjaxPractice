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
            ViewBag.Employees = GetEmpModels();
            return View();
        }



        public ActionResult Employee(int? id)
        {

            return View();
        }
        public PartialViewResult Alphabetical()
        {
            //Returns alphabetically.
            List<EmpModel> model = db.Emps.OrderBy(x => x.Name).ToList();
            return PartialView("_BLAHBLAHBLAH", model);
        }


        public PartialViewResult All()
        {
            //Get by key order.
            List<EmpModel> model = db.Emps.ToList();
            return PartialView("_BLAHBLAHBLAH", model);
        }

        private IQueryable<EmpModel> GetEmpModels ()
        {
            var Employees = from Employee in db.Emps
                             select new EmpModel
                             {
                                 Name = Employee.Name,
                                 City = Employee.City,
                                 Address = Employee.Address
                            };
            return Employees;
}

    }
}

