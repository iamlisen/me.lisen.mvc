using me.lisen.Db;
using me.lisen.Db.CustomerDb;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace me.lisen.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            KernerBind();
        }

        /// <summary>
        /// 绑定
        /// </summary>
        private void KernerBind()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<ICustomerDb>().To<CustomerDb>();          
        }
    }
}
