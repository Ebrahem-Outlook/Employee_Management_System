using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        public String? FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public String? LastName { get; set; }

        [Required(ErrorMessage = "DateOfBirth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage ="Email is required")]
        public String? Email { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public String? Department { get; set; }
    }
}
