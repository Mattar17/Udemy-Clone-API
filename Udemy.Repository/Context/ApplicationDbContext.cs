using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.Entity;

namespace Udemy.Repository.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Course> Coureses { get; set; }
        public DbSet<Course_Chapter> CourseChapters { get; set; }
        public DbSet<Chapter_Lecture> ChapterLectures { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseReview> CourseReviews { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }

    }
}
