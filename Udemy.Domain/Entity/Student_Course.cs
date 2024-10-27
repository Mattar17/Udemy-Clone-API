using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Domain.Entity
{
    public class Student_Course
    {
        public string StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ApplicationUser User { get; set; }
        public Course Course { get; set; }
        public int LastWatchedLectureId { get; set; }
        public int CompletedPercentage { get; set; }
    }
}
