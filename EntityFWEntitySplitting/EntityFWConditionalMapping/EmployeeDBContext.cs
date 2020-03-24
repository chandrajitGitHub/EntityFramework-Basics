using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFWConditionalMapping
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Map(x => x.Requires("IsTerminated")
                                                      .HasValue("false"))
                                           .Ignore(x => x.IsTerminated);

            base.OnModelCreating(modelBuilder);
        }
    }
}