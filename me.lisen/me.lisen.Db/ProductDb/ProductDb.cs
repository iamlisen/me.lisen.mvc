using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using me.lisen.Models;
using System.Data.Entity;

namespace me.lisen.Db.ProductDb
{
    public class ProductDb : IProductDb
    {
        private NorthwindContext context;
        public ProductDb(NorthwindContext context)
        {
            this.context = context;
        }

        public List<dynamic> GetProducts()
        {
            var query = from p in context.Products
                        join c in context.Categories
                        on p.CategoryID equals c.CategoryID
                        select new
                        {
                            productName = p.ProductName,
                            catagoryName = c.CategoryName
                        };
            return query.ToList<dynamic>();
        }
    }
}
