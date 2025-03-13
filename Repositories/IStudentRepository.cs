using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student?> GetStudentDetailsByIdAsync(int id);
    }
}
