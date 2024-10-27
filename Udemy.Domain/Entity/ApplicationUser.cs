using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Domain.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string PricureUrl { get; set; }
        public ICollection<Student_Course> Student_Courses { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Message> SentMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
