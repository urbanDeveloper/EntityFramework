using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnitiyFrameworkM2MCodeFirst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();

            //using LINQ - needs to convert to a list
            GridView1.DataSource = (from student in studentDBContext.Students
                                    from course in student.Courses
                                    select new
                                    {
                                        StudentName = student.StudentName,
                                        CourseName = course.CourseName
                                    }).ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();

            Course WCFCourse = studentDBContext.Courses.FirstOrDefault(x => x.CourseID == 4);
            //by using the include method becuase it is load all the related entityies - this is called lazy loading.
            studentDBContext.Students.Include("Courses").FirstOrDefault(x => x.StudentId == 1).Courses.Add(WCFCourse);
            studentDBContext.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();
            //Find the Course
            Course SQLServerCourse = studentDBContext.Courses.FirstOrDefault(x => x.CourseID == 3);

            // Get John and Remove John from the SQL SERVER Course = 3
            studentDBContext.Students.Include("Courses").FirstOrDefault(x => x.StudentId == 2).Courses.Remove(SQLServerCourse);
            studentDBContext.SaveChanges();
        }
    }
}