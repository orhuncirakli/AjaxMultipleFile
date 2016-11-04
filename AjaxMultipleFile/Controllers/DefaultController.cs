using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxMultipleFile.DAL;
using AjaxMultipleFile.Models;
using AjaxMultipleFile.ViewModel;

namespace AjaxMultipleFile.Controllers
{
    public class DefaultController : Controller
    {
        AjaxEntity db = new AjaxEntity();

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Process(Common model)
        {
            try
            {
                db.Customers.Add(model.Customer);
                db.Employees.Add(model.Employee);
                db.Entry(model.Employee).State = EntityState.Added;
                db.Entry(model.Customer).State = EntityState.Added;
                db.SaveChanges();
                return Json(JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}