using System;
using System.ComponentModel.DataAnnotations;

using System.Xml.Linq;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; } 
        public string Department { get; set; }
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        public double Salary { get; set; } 


    }
}