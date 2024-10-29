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
    internal class ChapterLecturesConfigurations : IEntityTypeConfiguration<Chapter_Lecture>
    {
        public void Configure(EntityTypeBuilder<Chapter_Lecture> builder)
        {
            builder.HasOne(l => l.Course_Chapter)
                .WithMany(c => c.Chapter_Lectures)
                .HasForeignKey(l => l.ChapterId);
        }
    }
}
