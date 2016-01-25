using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstStoreProcedure
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
            Employee employeeToUpdate = employeeDBContext.Employees.FirstOrDefault(x => x.Id == employee.Id);
            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.Salary = employee.Salary;
            employeeDBContext.SaveChanges();
        }

        //Delete Employee
        public void DeleteEmployee(Employee employee)
        {
            Employee employeeToDelete = employeeDBContext.Employees.FirstOrDefault(x => x.Id == employee.Id);
            employeeDBContext.Employees.Remove(employeeToDelete);            
            employeeDBContext.SaveChanges();
        }
    }
}
