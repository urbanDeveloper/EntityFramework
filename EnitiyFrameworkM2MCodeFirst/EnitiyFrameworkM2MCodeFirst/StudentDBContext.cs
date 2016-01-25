using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitiyFrameworkM2MCodeFirst
{
    public class StudentDBContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        //When creating the tables using many to many
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasMany(t => t.Courses)
            .WithMany(t => t.Students)
            .Map(m =>
            {
                m.ToTable("StudentCourses");
                m.MapLeftKey("StudentID");
                m.MapRightKey("CourseID");
            });

       base.OnModelCreating(modelBuilder);
            }
        }

    }
