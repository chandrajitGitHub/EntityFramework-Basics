using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFWTPH
{
    public class ContractEmployee : Employee
    {
       
        public int HoursWorked { get; set; }
        
        public int HourlyPay { get; set; }
    }
}