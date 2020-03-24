using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFWTPT
{
    [Table("PermanentEmployees")]
    public class PermanentEmployee : Employee
    {
        public int AnnualSalary { get; set; }
    }
}