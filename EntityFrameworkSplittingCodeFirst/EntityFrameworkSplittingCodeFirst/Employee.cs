using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSplittingCodeFirst
{
    /// <summary>
    /// Entity Splitting refers to mapping an entity into two or more tables with the tables shareing the common key. 
    /// </summary>
    class Employee
    {
        //These property values should be stored in Employees Table
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        //These property values should be stored in EmployeeContactDetails Table

        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Landline { get; set; }
    }
}
