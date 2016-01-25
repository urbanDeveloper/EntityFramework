using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTPTCodeFirst
{
    //[Table("PermanentEmployees")]
    public class PermanentEmployee : Employee
    {
        public int AnnualSalary { get; set; }
    }
}
