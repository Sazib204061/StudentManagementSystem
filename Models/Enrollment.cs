namespace StudentManagementSystem.Models
{
    public class Enrollment
    {
        public int StudentId { get; set; }   //primary key
        public Student? Student { get; set; }  //one connection to Student
        public int CourseId { get; set; }      //foreign key
        public Course? Course { get; set; }   //one connection to Course
    }
}
