using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSSecondApp.Models;

namespace AngularJSSecondApp.Controllers
{
    public class EmployeeController : Controller
    {
        KudVenkatEntities db = new KudVenkatEntities();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees()
        {

            return View();
        }
        public JsonResult GetEmployeesData()
        {
           
            return Json(db.tblEmployees.ToList(),JsonRequestBehavior.AllowGet);
        }
        
    }
}