using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Domain.Entity
{
    public class Chapter_Lecture
    {
        public int Id { get; set; }
        public string Lecture_Title { get; set; }
        public string MediaUrl { get; set; }
        public int ChapterId { get; set; }

    }
}
