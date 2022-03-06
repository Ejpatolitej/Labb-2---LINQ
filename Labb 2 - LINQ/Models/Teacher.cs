using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___LINQ.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }

        public ICollection<TeacherClass> TeacherClasses { get; set; }
    }
}
