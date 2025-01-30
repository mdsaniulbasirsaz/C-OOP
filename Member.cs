using System;

public class Member
{
    //Class Members
    // string color = "Blue";
    // int age = 25;

    public string? Color;
    public string? Age;

    public void MemberDetails()
    {
        Console.WriteLine("Member Color: " + Color);
        Console.WriteLine($"Age: {Age}");
    }
}