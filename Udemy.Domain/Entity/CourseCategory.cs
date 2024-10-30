﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Domain.Entity
{
    public class CourseCategory
    {
        public int Id { get; set; }
        public string Category {get; set; }

        public ICollection<Course>? Courses { get; set; }
    }
}
