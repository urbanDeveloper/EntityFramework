using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTableSplittingCodeFirst
{
    /// <summary>
    /// Mapping multiple entities to a single table is called table splitting
    /// Why use Table Splitting?
    /// Table Splitting is useful when you want to delay the loading of some properties with large data when using lazy loading
    /// </summary>
    class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public EmployeeContactDetail EmployeeContactDetail {get; set;}

    }
}
