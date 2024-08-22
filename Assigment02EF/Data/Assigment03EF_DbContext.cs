using Assigment03EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Assigment03EF.Data
{
    public class Assigment03EF_DbContext : DbContext
    {

        public Assigment03EF_DbContext(DbContextOptions<Assigment03EF_DbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> CourseInstructors { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public Assigment03EF_DbContext() : base() 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
              
             optionsBuilder.UseSqlServer("Server = . ; Database = ITI_Student ; Trusted_connection = true ; TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentID);
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dep_Id);

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });
            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudCourses)
                .HasForeignKey(sc => sc.stud_ID);
            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudCourses)
                .HasForeignKey(sc => sc.Course_ID);


            modelBuilder.Entity<Course>()
                .HasKey(c => c.ID);
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.Top_ID);


            modelBuilder.Entity<Department>()
                .HasKey(d => d.ID);
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithMany(i => i.Departments)
                .HasForeignKey(d => d.Ins_ID);

            modelBuilder.Entity<Topic>()
                .HasKey(t => t.ID);

            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID });
            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.inst_ID);
            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.Course_ID);

            modelBuilder.Entity<Instructor>()
                .HasKey(i => i.ID);
        }
    }


}
