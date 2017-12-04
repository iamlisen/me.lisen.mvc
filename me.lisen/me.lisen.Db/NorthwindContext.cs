using me.lisen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace me.lisen.Db
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("SqlServer")
        {

        }

        public DbSet<Customer> Customers { get; set; }


    }
}
