using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repositories
{
    public class EnrollmentRepository : BaseRepository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(AppDbContext context) : base(context) { }

        private bool EnrollmentExistsAsync(int courseId, int studentId)
        {
            return _dbSet.Any(e => e.CourseId == courseId && e.StudentId == studentId);
        }

        public async Task<IEnumerable<Enrollment>> GetCourseEnrollmentsAsync(int courseId)
        {
            return await _dbSet
                .Include(e => e.Student)
                .Include(e => e.Course)
                .Where(e => e.CourseId == courseId)
                .ToListAsync();
        }

        public override async Task AddAsync(Enrollment entity)
        {
            if (EnrollmentExistsAsync(entity.CourseId, entity.StudentId))
                throw new Exception($"Student with Id:{entity.StudentId} already enrolled to Course with Id:{entity.CourseId}");

            await base.AddAsync(new Enrollment
            {
                CourseId = entity.CourseId,
                StudentId = entity.StudentId,
            });
        }
    }
}
