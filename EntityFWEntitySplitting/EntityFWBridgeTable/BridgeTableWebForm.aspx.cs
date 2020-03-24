using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFWBridgeTable
{
    public partial class BridgeTableWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();
            studentDBContext.Database.CommandTimeout = 540;
            GridView1.DataSource = (from student in studentDBContext.Students
                                    from studentCourse in student.StudentCourses
                                    select new
                                    {
                                        student.StudentName,
                                        studentCourse.Course.CourseName,
                                        studentCourse.EnrolledDate
                                    }).ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();
            studentDBContext.StudentCourses.Add(new StudentCourse
            { StudentID = 1, CourseID = 4, EnrolledDate = DateTime.Now });
            studentDBContext.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();
            StudentCourse studentCourseToRemove = studentDBContext.StudentCourses
                .FirstOrDefault(x => x.StudentID == 2 && x.CourseID == 3);
            studentDBContext.StudentCourses.Remove(studentCourseToRemove);
            studentDBContext.SaveChanges();
        }
    }
}