using me.lisen.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace me.lisen.Db
{
    public class NorthwindContext : DbContext
    {
        [Inject]
        public NorthwindContext() : base("SqlServer")
        {

        }

        public DbSet<Customer> Customers { get; set; }


    }
}
