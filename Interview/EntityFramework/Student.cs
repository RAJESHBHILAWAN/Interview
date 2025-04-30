using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.EntityFramework
{
    public class Student
    {
        public int Id { get; set; }
        public string? StudentName { get; set; }
       
        
        [ForeignKey("Course")]
        public int CourseID
        {
            get; set;
        }

        public required Course Courses { get; set; }
    }
}
