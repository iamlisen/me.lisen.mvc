using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Web.Mvc;
using me.lisen.Db.CustomerDb;
using System.Web.Routing;
using System.Web;

namespace me.lisen.Util.Loc
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        IKernel kernel;
        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBinding();
        }

        protected override IController GetControllerInstance(RequestContext context,Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }

        public void AddBinding()
        {
            kernel.Load(HttpContext.Current.Server.MapPath(".")+"\\XmlConfig\\Ninject.xml");
            //kernel.Bind<ICustomerDb>().To<CustomerDb>();
        }
    }
}
