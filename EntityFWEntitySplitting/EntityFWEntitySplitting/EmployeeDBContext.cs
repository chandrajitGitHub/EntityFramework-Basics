using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFWEntitySplitting
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Map(map =>
            {
                map.Properties(p => new
                {
                    p.EmployeeId,
                    p.FirstName,
                    p.LastName,
                    p.Gender
                });
                map.ToTable("Employees");
            })
            .Map(map =>
            {
                map.Properties(p => new
                {
                    p.EmployeeId,
                    p.Email,
                    p.Landline,
                    p.Mobile
                });
                map.ToTable("EmployeeContact");
            });



            base.OnModelCreating(modelBuilder);
        }
    }
}