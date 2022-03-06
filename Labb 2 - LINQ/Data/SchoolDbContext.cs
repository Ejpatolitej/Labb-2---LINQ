using Labb_2___LINQ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___LINQ.Data
{
    internal class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseClass> CourseClasses { get; set; }
        public DbSet<TeacherClass> TeacherClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = EJPATOLITEJ; Initial Catalog = Labb2-LINQ; Integrated Security = True;");
        }
    }
}
