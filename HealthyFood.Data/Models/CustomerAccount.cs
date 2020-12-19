using System;
using System.Collections.Generic;

namespace HealthyFood.Data.Models
{
    public partial class CustomerAccount
    {
        public string CustomerName { get; set; }
        public string CustomerPass { get; set; }
        public string CustomerId { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
