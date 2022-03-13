using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___LINQ.Models
{
    public class CourseClass
    {
        [Key]
        public int CourseClassID { get; set; }
        public int fkCourseID { get; set; }
        public int fkClassID { get; set; }

        public Course Course { get; set; }
        public Class Class { get; set; }
    }
}
