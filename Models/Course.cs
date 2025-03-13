namespace StudentManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public ICollection<Enrollment> Enrollments { get; set; } = [];  //many connection to Enrollment
    }
}
