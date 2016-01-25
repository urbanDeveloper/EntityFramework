using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkCodeFirstStoreProcedure
{
    class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        //create stored procedures - first you type in override and space and select which method you want to use i.e.OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //OVERLOADING STORED PROCEDURES
            modelBuilder.Entity<Employee>().MapToStoredProcedures
                //Inserting the Insert()method
                //Changing the name of the store procedure to whatever string specified
                (p => p.Insert(i => i.HasName("InsertEmployee")
                    //Changing the store procedure parameters.
                      .Parameter(n => n.Name, "EmployeeName")
                      .Parameter(n => n.Gender, "EmployeeGender")
                      .Parameter(n => n.Salary, "EmployeeSalary"))
                //Inserting the Update()method
                .Update(u => u.HasName("UpdateEmployee")
                       .Parameter(n => n.Id, "EmployeeID")
                       .Parameter(n => n.Name, "EmployeeName")
                       .Parameter(n => n.Gender, "EmployeeGender")
                       .Parameter(n => n.Salary, "EmployeeSalary"))
                //Inserting the Delete()method
                .Delete(d => d.HasName("DeleteEmployee")
                        .Parameter(n => n.Id, "EmployeeID"))
                );
                
            base.OnModelCreating(modelBuilder);
        }

    }
}
