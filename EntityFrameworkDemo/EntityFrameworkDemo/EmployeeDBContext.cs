using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI.WebControls;

namespace EntityFrameworkDemo
{
    public class EmployeeDBContext : DbContext
    {
        
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        
    }
}