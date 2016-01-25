using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    // This class contains all the methods - using CRUD (create, read, write , delete)
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            return employeeDBContext.Departments.Include("Employees").ToList();
            
        }
    }
}
