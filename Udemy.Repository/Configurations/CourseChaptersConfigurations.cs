using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.Entity;

namespace Udemy.Repository.Configurations
{
    internal class CourseChaptersConfigurations : IEntityTypeConfiguration<Course_Chapter>
    {
        public void Configure(EntityTypeBuilder<Course_Chapter> builder)
        {
            builder.HasOne(cc => cc.Course)
                .WithMany(c => c.Course_Chapters)
                .HasForeignKey(cc => cc.Course_id);
        }
    }
}
