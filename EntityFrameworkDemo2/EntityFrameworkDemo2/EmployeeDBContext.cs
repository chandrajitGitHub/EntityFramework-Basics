using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo2
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // This line will tell entity framework to use stored procedures
            // when inserting, updating and deleting Employees

            modelBuilder.Entity<Employee>().MapToStoredProcedures
                (p => p.Insert(x => x.HasName("InsertEmployee")
                                     .Parameter(y => y.Name, "EmployeeName")
                                     .Parameter(y => y.Gender, "EmployeeGender")
                                     .Parameter(y => y.Salary, "EmployeeSalary"))

                       .Update(x => x.HasName("UpdateEmployee")
                                     .Parameter(y => y.ID, "EmployeeID")
                                     .Parameter(y => y.Name, "EmployeeName")
                                     .Parameter(y => y.Gender, "EmployeeGender")
                                     .Parameter(y => y.Salary, "EmployeeSalary"))

                       .Delete(x => x.HasName("DeleteEmployee")
                                     .Parameter(y => y.ID, "EmployeeID"))
                 );
            
            base.OnModelCreating(modelBuilder);
        }
    }
}