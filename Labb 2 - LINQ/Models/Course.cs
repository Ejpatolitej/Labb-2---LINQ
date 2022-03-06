using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___LINQ.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }

        public ICollection<CourseClass> CourseClass { get; set; }
        public ICollection<Student> Student { get; set; }


    }
}
