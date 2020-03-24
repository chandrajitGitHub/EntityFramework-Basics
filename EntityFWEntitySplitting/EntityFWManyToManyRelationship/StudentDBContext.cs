using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFWManyToManyRelationship
{
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set;}
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(t => t.Courses)
                .WithMany(t => t.Students)
                .Map(m => 
                    {
                        m.ToTable("StudentCourses");
                        m.MapLeftKey("StudentId");
                        m.MapRightKey("CourseId");
                    }); 

            base.OnModelCreating(modelBuilder);
        }
    }
}