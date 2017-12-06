using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using me.lisen.Models;
using Ninject;
using System.Data.Entity;

namespace me.lisen.Db.CustomerDb
{
    public class CustomerDb : ICustomerDb
    {
        private readonly NorthwindContext context;

        [Inject]
        public CustomerDb()
        {
            context = new NorthwindContext();
        }
        
        public List<Customer> GetCustomers()
        {
            return context.Customers.ToList<Customer>();
        }

        public List<Customer> GetCustomers(string whereKey, string whereValue)
        {
            return context.Customers.Where(e => e.ContactName == whereValue).ToList<Customer>();
        }
    }
}
