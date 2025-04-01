using System;

public class Student
{
    public string Name { get; set; }
    public static string SchoolName { get; set; } = "ABC School";

    public string studentName
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Name cannot be empty"); // This will execute if value is null or empty
            }
            else
            {
                Name = value; // This sets the Name if the value is not empty
            }
        }
        get
        {
            return Name ?? "username not set"; // If Name is null, it will return "username not set"
        }
    }
}
abstract class Employee
{
    public abstract string Name { get; set; }
}
class Myclass : Employee
{
    private string _name;
    public override string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
}

    internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();
        Console.WriteLine(Student.SchoolName); // Prints the static SchoolName

        // Prints "username not set" because Name is not set yet
        Console.WriteLine(student.studentName);

        // Assigning an empty string triggers the "Name cannot be empty" message
        student.studentName = "";
        // Prints "username not set" because the Name is still not set
        Console.WriteLine(student.studentName);

        // Now assign a valid name
        student.studentName = "Rajesh";
        // Prints "Rajesh" because the Name was set correctly
        Console.WriteLine(student.studentName);
        Myclass myclass = new Myclass();
        myclass.Name = "Rajesh_UsingAbtract";
        Console.WriteLine(myclass.Name);
       Employee employee = new Myclass();
        employee.Name = "Rajesh_UsingAbtract";
        Console.WriteLine(employee.Name);
    }
}
