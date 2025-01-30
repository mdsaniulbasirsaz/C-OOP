// Program.cs
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Creating a Student object
        Student student = new Student
        {
            Name = "John Doe",
            Address = "123 Main St",
            Mobile = "123-456-7890",
            Email = "johndoe@example.com",
            DeptName = "Computer Science"
        };
        student.DisplayStudentDetails();

        // Creating a Course object
        Course course = new Course
        {
            CourseName = "Introduction to Programming",
            CourseCode = "CS101",
            CourseDuration = "12 weeks",
            CourseFee = "$1000",
            CourseDescription = "This course introduces students to the basics of programming."
        };
        course.CourseDetails();

        Member member1 = new Member();
        member1.Color ="Blue";
        member1.Age = "24";
        Member member2 = new Member();
        member2.Color = "Red";
        member2.Age = "25";
        member1.MemberDetails();
        member2.MemberDetails();

        Constructor model = new Constructor();
        model.ShowModel();
    }
}
