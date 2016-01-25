using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    //changing the table name
   //Table("tblEmployees")]
    public class Employee
    {
        public int Id { get; set; }
        //changing the column name
        //[Column("First_Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        //want the departmentId to be generated without an underscore
        public int DepartmentId { get; set; }
        //attribute
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public string JobTitle { get; set; }

    }
}
