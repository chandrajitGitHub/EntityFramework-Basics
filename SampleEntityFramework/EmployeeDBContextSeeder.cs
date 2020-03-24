using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleEntityFramework
{
    public class EmployeeDBContextSeeder : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee()
            {
                Name = "Hastings",   
                Gender = "Male",
                Salary = 60000,                
            };
            employees.Add(employee1);
            Employee employee2 = new Employee()
            {

                Name = "Max",
                Gender = "Male",
                Salary = 50000,
            };
            employees.Add(employee2);
            Employee employee3 = new Employee()
            {
         
                Name = "Joyee",
                Gender = "Female",
                Salary = 75000,
            };

            employees.Add(employee3);
            Employee employee4 = new Employee()
            {
     
                Name = "Sreemoyee",
                Gender = "Female",
                Salary = 45000,
            };
            employees.Add(employee4);
            Employee employee5 = new Employee()
            {

                Name = "Subir",
                Gender = "Male",
                Salary = 60000,
            };
            employees.Add(employee5);
            Employee employee6 = new Employee()
            {
         
                Name = "Lucas",
                Gender = "Male",
                Salary = 95000,
            };
            employees.Add(employee6);
            Employee employee7 = new Employee()
            {
                Name = "Boy",
                Gender = "Male",
                Salary = 35000,
            };
            employees.Add(employee7);
            Employee employee8 = new Employee()
            {

                Name = "Jyoti",
                Gender = "Female",
                Salary = 65000,
            };

            employees.Add(employee8);

            context.Employees.AddRange(employees);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}