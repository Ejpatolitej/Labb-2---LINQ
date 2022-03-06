using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___LINQ.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

        public Course Course { get; set; }
    }
}
