using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSplittingCodeFirst
{
    class EmployeeRespository
    {
        EmployeeDBContext employeeDBContext = new EmployeeDBContext();

        public List<Employee> GetEmployee()
        {
            return employeeDBContext.Employees.ToList();
        }

        //Add Employee
        public void InsertEmployee(Employee employee)
        {
            employeeDBContext.Employees.Add(employee);
            employeeDBContext.SaveChanges();
        }

        //Updating Employee
        public void UpdateEmployee(Employee employee)
        {
            //within the employee collection , you want to retrive the employee and update via ID.
            Employee employeeToUpdate = employeeDBContext.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            employeeToUpdate.EmployeeId = employee.EmployeeId;
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.Mobile = employee.Mobile;
            employeeToUpdate.Landline = employee.Landline;

            employeeDBContext.SaveChanges();
        }

        //Delete Employee
        public void DeleteEmployee(Employee employee)
        {
            Employee employeeToDelete = employeeDBContext.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            employeeDBContext.Employees.Remove(employeeToDelete);
            employeeDBContext.SaveChanges();
        }
    }
}
