using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(200);
            builder.HasMany(c => c.Enrollments)   //c for course
                   .WithOne(e => e.Course)        //e for enrollment
                   .HasForeignKey(e => e.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
