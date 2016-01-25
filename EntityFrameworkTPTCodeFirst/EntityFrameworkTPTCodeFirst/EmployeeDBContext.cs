using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkTPTCodeFirst
{
    public class EmployeeDBContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Instead of using attributes [Table("Employees")], below code will build the tables for you. 
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<PermanentEmployee>().ToTable("PermanentEmployees");
            modelBuilder.Entity<ContractEmployee>().ToTable("ContractEmployees");
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
