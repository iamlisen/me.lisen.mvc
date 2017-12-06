using me.lisen.Db;
using me.lisen.Db.CustomerDb;
using me.lisen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace me.lisen.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerDb customerDb;
        
        public CustomerController() {
            IKernel kernel = new StandardKernel();
            customerDb = kernel.Get<ICustomerDb>();           
        }

        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.Customers = customerDb.GetCustomers();
            return View();
        }
    }
}