
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;

namespace PAS.Models
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        
        [Required(ErrorMessage ="First name is required")]
        [StringLength(100,MinimumLength =2)]

        public string FirstName{ get; set; }
        [Required]
        public string LastName{ get; set; }
        [Required]
        public string Email{ get; set; }
       
        public DateTime DateOfBirth{ get; set; }
        public Gender Gender{ get; set; }
        public int  MyProperty{ get; set; }
        public Department  Department{ get; set; }
        public int  DepartmentId{ get; set; }
        public int  DepartmentName{ get; set; }
        public string PhotoPath{ get; set; }
    }
    public enum Gender{
        Male,Female
    }
}