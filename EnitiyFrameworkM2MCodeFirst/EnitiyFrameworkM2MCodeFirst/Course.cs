using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitiyFrameworkM2MCodeFirst
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public IList<Student> Students { get; set; }
    }
}
