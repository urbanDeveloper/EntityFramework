using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTPHCodeFirst
{
    public class PermanentEmployee :Employee
    {
        [Column(Order = 5)]
        public int ?AnnualSalary { get; set; }
    }
}
