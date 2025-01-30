// Student.cs
using System;

public class Student
{
    public string? Name;
    public string? Address;
    public string? Mobile;
    public string? Email;
    public string? DeptName;

    public void DisplayStudentDetails()
    {
        Console.WriteLine("Student Details:\n");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("Mobile: " + Mobile);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Department: " + DeptName);
        Console.WriteLine("\n");
    }
}
