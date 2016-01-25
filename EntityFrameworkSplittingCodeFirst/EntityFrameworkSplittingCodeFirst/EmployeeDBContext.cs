using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkSplittingCodeFirst
{
    class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        //Splitting Employee table into two and having the same entity in both tables(EmployeeId) . 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Map(map =>
            {
                map.Properties(p => new
                {
                    p.EmployeeId,
                    p.FirstName,
                    p.LastName,
                    p.Gender
                });
                map.ToTable("Employees");
            })

            //EmployeeContactDetails
            .Map(map =>
            {
                map.Properties(p => new
                {
                    p.EmployeeId, 
                    p.Email,
                    p.Landline, 
                    p.Mobile
                });
                map.ToTable("EmployeeContactDetails");
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
