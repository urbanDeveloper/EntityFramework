﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkBridgeTblM2MCodeFirst
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }

    }
}