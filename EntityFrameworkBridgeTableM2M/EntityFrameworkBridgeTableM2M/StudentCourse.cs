//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkBridgeTableM2M
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentCourse
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Nullable<System.DateTime> EnrolledDate { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
