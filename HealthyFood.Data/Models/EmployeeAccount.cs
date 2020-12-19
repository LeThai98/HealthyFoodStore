using System;
using System.Collections.Generic;

namespace HealthyFood.Data.Models
{
    public partial class EmployeeAccount
    {
        public string EmployeeName { get; set; }
        public string EmployeePass { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employees Employee { get; set; }
    }
}
