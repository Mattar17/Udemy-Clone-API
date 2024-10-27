using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Domain.Entity
{
    public class Course_Chapter
    {
        public int Id { get; set; }
        public string Chapter_Name { get; set; }
        public int Chapter_Number { get; set; }
        public Guid Course_id { get; set; }
        public ICollection<Chapter_Lecture> Chapter_Lectures { get; set; }
    }
}
