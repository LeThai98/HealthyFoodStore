using System;
using System.Collections.Generic;

namespace HealthyFood.Data.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string District { get; set; }
        public string CusUserName { get; set; }
        public string CusPassword { get; set; }

        public virtual CustomerAccount CustomerAccount { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
