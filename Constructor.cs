using System;
using System.Runtime.InteropServices;

public class Constructor
{
    public string? Model;
    public Constructor()
    {
        Model = "Mustang";
    }

    public void ShowModel()
    {
        Console.WriteLine("Car Model: " + Model);
    }

}