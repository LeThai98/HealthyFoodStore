using System;
using System.Collections.Generic;

namespace HealthyFood.Data.Models
{
    public partial class Employees
    {
        public Employees()
        {
            InverseManager = new HashSet<Employees>();
            Orders = new HashSet<Orders>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public byte[] Image { get; set; }
        public string Notes { get; set; }
        public int? ManagerId { get; set; }
        public string EmagePath { get; set; }
        public string Email { get; set; }

        public virtual Employees Manager { get; set; }
        public virtual EmployeeAccount EmployeeAccount { get; set; }
        public virtual ICollection<Employees> InverseManager { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
