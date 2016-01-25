using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkBridgeTableM2M
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();

            var qurey = from course in studentDBContext.Courses
                        from studentCourse in course.StudentCourses
                        //LINQ Query
                        select new
                        {
                            StudentName = studentCourse.Student.StudentName,
                            CourseName = course.CourseName,
                            EnrolledDate = studentCourse.EnrolledDate
                        };

            //convert query to list
            GridView1.DataSource = qurey.ToList();
            //bind the grid view
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();

            StudentCourse WCFCourseForMike = new StudentCourse
            {
                StudentID = 1,
                CourseID = 4,
                EnrolledDate = DateTime.Now
            };
            studentDBContext.StudentCourses.Add(WCFCourseForMike);
            studentDBContext.SaveChanges();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();

            StudentCourse studentCourseToRemove = studentDBContext.StudentCourses.FirstOrDefault(x => x.StudentID == 2 && x.CourseID == 3);

            studentDBContext.StudentCourses.Remove(studentCourseToRemove);
            studentDBContext.SaveChanges();
        }
    }
}