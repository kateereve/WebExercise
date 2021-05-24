using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagementSytem
{
    public class Transaction
    {
        public int id { get; set; }
        public List<Product> products { get; set; }
        public decimal amount { get; set; }
        public decimal cash { get; set; }
    }
}
