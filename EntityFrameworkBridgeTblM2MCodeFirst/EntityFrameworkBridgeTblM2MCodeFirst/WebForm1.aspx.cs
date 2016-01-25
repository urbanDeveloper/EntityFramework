using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkBridgeTblM2MCodeFirst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();
            GridView1.DataSource = (from student in studentDBContext.Students
                                    from studentCourse in student.StudentCourses
                                    select new
                                    {
                                        StudentName = student.StudentName,
                                        CourseName = studentCourse.Course.CourseName,
                                        EnrolledDate = studentCourse.EnrolledDate
                                    }).ToList();
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