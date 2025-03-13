using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);

            // One-to-One with StudentProfile
            builder.HasOne(s => s.Profile)
                   .WithOne(p => p.Student)
                   .HasForeignKey<StudentProfile>(p => p.Id) // Shared PK
                   .OnDelete(DeleteBehavior.Cascade);

            // One-to-Many with Enrollment
            builder.HasMany(s => s.Enrollments)
                   .WithOne(e => e.Student)
                   .HasForeignKey(e => e.StudentId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
