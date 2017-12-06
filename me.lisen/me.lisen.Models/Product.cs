using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace me.lisen.Models
{
    public class Product
    {
        [Key]
        public string ProductID { get; set; }

        [Required(ErrorMessage ="产品名称必填")]
        public string ProductName { get; set; }

        public string SupplierID { get; set; }

        public string CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public string UnitPrice { get; set; }

        public string UnitsInStock { get; set; }

        public string UnitsOnOrder { get; set; }

        public string ReorderLevel { get; set; }

        public string Discontinued { get; set; }
    }
}
