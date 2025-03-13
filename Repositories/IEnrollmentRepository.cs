using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repositories
{
    public interface IEnrollmentRepository : IRepository<Enrollment>
    {
        Task<IEnumerable<Enrollment>> GetCourseEnrollmentsAsync(int courseId);
    }
}
