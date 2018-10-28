using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyDemo.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }

        public string Name { get; set; }
    }
}
