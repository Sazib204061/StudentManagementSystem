using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data.Configurations
{
    public class StudentProfileConfiguration : IEntityTypeConfiguration<StudentProfile>
    {
        public void Configure(EntityTypeBuilder<StudentProfile> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Bio).HasMaxLength(500);
        }
    }
}
