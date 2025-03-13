namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }  //primary key
        public string Name { get; set; } = string.Empty;
        public StudentProfile? Profile { get; set; }     //one connection to StudentProfile
        public ICollection<Enrollment> Enrollments { get; set; } = [];   //many connection to Enrollment
    }
}
