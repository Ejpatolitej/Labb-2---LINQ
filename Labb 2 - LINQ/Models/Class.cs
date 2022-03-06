using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___LINQ.Models
{
    public class Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }

        public ICollection<CourseClass> CourseClasses { get; set; }
        public ICollection<TeacherClass> TeacherClasseses { get; set; }

    }
}
