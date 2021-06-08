using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_EntityFrameWorkCore.Models
{
    class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public IList<StudentCourses> StudentCourses { get; set; }
    }
}
