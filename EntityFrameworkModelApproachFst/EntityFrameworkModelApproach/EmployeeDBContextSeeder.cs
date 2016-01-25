using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFrameworkCodeFirst
{
    /// <summary>
    /// We are populating the database with test data using insert SQLScript. HOWEVER Entity Framework can automate this.
    /// step 1 Add a class file with a name = EmployeeDBContextSeeder.cs
    /// step 2 Modify the Application_Start()method in the Gobal file.
    /// step 3 Run the application and notice that the Sample database, Departments and Employees tables are created and populated with test data automatically
    /// </summary>
    //Inhert from your Gobal class the DropCreateDatabaseIfModelChanges method with EmployeeDBContext
    public class EmployeeDBContextSeeder : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            Department department1 = new Department()
            {
                //Insert this in the department table
                Name = "IT",
                Location = "New York",

                // Inserting employee in the IT department above
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "Amar", 
                        LastName = "Chavda", 
                        Gender = "Male",
                        Salary = 60000, 
                        JobTitle = "Graduate Developer"
                    },

                      new Employee()
                    {
                        FirstName = "Nish", 
                        LastName = "Patel", 
                        Gender = "Male",
                        Salary = 75000, 
                        JobTitle = "Web Developer"
                    },

                       new Employee()
                    {
                        FirstName = "Nish", 
                        LastName = "Patel", 
                        Gender = "Male",
                        Salary = 75000, 
                        JobTitle = "Web Developer"
                    }

                }
            };

            Department department2 = new Department()
            {
                Name = "HR",
                Location = "Leicester",
                Employees = new List<Employee>() 
                {
                    new Employee()
                    {
                        FirstName = "Chhaya", 
                        LastName = "Chavda", 
                        Gender = "Female",
                        Salary = 65000, 
                        JobTitle = "Careers Advisor"
                    },

                    new Employee()
                    {
                        FirstName = "Mary", 
                        LastName = "Bennet", 
                        Gender = "Female",
                        Salary = 70000, 
                        JobTitle = "Receptionest"
                    }
                }
            };

            Department department3 = new Department()
            {
                Name = "Payroll",
                Location = "London",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "Vishnu", 
                        LastName = "Chavda", 
                        Gender = "Male",
                        Salary = 80000, 
                        JobTitle = "Finance Accountant"
                    },

                    new Employee()
                    {
                        FirstName = "Steve", 
                        LastName = "Pound", 
                        Gender = "Male",
                        Salary = 45000, 
                        JobTitle = "Sr. Payroll Admin"
                    }
                }
            };


            //Adding method to the DB
            context.Departments.Add(department1);
            context.Departments.Add(department2);
            context.Departments.Add(department3);
            base.Seed(context);
        }
    }
}