using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace EntityFrameworkDemo
{
    public class EmployeeRepository
    {
        
        public List<Department> GetDepartments()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            employeeDBContext.Database.CommandTimeout = 540;

            return employeeDBContext.Departments.Include("Employees").ToList();
        }
    }
}