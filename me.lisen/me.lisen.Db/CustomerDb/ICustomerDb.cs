using me.lisen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace me.lisen.Db.CustomerDb
{
    public interface ICustomerDb
    {
        List<Customer> GetCustomers();
        List<Customer> GetCustomers(string whereKey, string whereValue);
    }
}
