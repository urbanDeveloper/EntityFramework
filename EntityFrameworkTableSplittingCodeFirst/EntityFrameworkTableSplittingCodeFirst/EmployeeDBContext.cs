using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTableSplittingCodeFirst
{
    class EmployeeDBContext :DbContext 
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Mapping the Employee entity to the Employee table
            modelBuilder.Entity<Employee>()
                .HasKey(pk => pk.EmployeeId)
                .ToTable("Employees");

            //Mapping EmployeeContactDetail to the Employee table
            modelBuilder.Entity<EmployeeContactDetail>()
                .HasKey(pk => pk.EmployeeId)
                .ToTable("Employees");

            modelBuilder.Entity<Employee>()
                //Dependant
                .HasRequired(p => p.EmployeeContactDetail)
                //Principle
                .WithRequiredPrincipal(c => c.Employee);

            base.OnModelCreating(modelBuilder);
        }

    }
}
