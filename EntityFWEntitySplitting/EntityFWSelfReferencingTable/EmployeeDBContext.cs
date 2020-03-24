using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFWSelfReferencingTable
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasOptional(x => x.Manager)
                .WithMany()
                .HasForeignKey(x => x.ManagerID);

            base.OnModelCreating(modelBuilder);
        }
    }
}