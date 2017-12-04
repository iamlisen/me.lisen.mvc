using me.lisen.Db;
using me.lisen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace me.lisen.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            NorthwindContext context = new NorthwindContext();
            ViewBag.Customers = context.Customers.ToList<Customer>();
            return View();
        }
    }
}