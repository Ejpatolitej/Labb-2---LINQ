using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___LINQ.Models
{
    public class TeacherClass
    {
        [Key]
        public int TeacherClassID { get; set; }
        //public int fkTeacherID { get; set; }
        //public int fkClassID { get; set; }

        public Teacher Teacher { get; set; }
        public Class Class { get; set; }
    }
}
