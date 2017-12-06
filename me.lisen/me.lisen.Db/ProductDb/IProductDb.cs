using me.lisen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace me.lisen.Db.ProductDb
{
    public interface IProductDb
    {
        List<dynamic> GetProducts();
    }
}
