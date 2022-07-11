using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeEvaluationTest.Models
{
    public class Employee
    {
     [Key]

       public int EmployeeID { get; set; }
        public string EmpDept { get; set; }
        [Required]
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }


    }
}
