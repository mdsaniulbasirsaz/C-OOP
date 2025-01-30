// Course.cs
using System;

public class Course
{
    public string? CourseName;
    public string? CourseCode;
    public string? CourseDuration;
    public string? CourseFee;
    public string? CourseDescription;

    public void CourseDetails()
    {
        Console.WriteLine("Course Details:\n");
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Course Code: " + CourseCode);
        Console.WriteLine("Course Duration: " + CourseDuration);
        Console.WriteLine("Course Fee: " + CourseFee);
        Console.WriteLine("Course Description: " + CourseDescription);
        Console.WriteLine("\n");
    }
}
