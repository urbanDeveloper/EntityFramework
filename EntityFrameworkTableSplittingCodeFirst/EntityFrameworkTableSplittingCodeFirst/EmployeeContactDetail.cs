using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTableSplittingCodeFirst
{
    class EmployeeContactDetail
    {
        public int EmployeeId {get; set; }
        public string Email {get;set;}
        public string Mobile {get; set;}
        public string LandLine {get; set;}

        public Employee Employee { get; set;}


    }
}
