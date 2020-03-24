using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo
{
    //[Table("tbl_Employees")]
    public class Employee
    {
        // Scalar Properties
        public int Id { get; set; }
        //[Column("First_Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        
        // Navigation Property
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        //Model Change
        public string JobTitle { get; set; }
    }

}