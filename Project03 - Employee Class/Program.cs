using System;
// Yoenis Hernandez
// 2/20/24
// COP 2551
// Professor Montalbano
public class Employee
{
    public string Name;
    public int IdNumber;
    public string Department;
    public string Position;

    // The Constructors
    public Employee(string name, int idNumber, string department, string position)
    {
        // Values as arguments and assigns to field
        Name = name;
        IdNumber = idNumber;
        Department = department;
        Position = position;
    }
    public Employee(string name, int idNumber)
    {
        // Values as arguments but dept and position have been left empty.
        Name = name;
        IdNumber = idNumber;
        Department = "";
        Position = "";
    }
    public Employee()
    {
        // All parameters are empty strings.
        Name = "";
        IdNumber = 0;
        Department = "";
        Position = "";
    }

    // Display the information for each employee function. Wasnt sure of the formatting
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine(
            "Name: " + Name +
            "\nID-Number: " + IdNumber +
            "\nDepartment: " + Department +
            "\nPosition: " + Position);
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
    }

    static void Main()
    {
        // Creating three Employee objects with example data
        Employee susan = new Employee("Susan Meyers", 479, "Accounting", "Vice President");
        Employee mark = new Employee("Mark Jones", 39119, "IT", "Programmer");
        Employee joy = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");

        // Displaying employee information
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Employee Information\n");
        
        // Calling the 3 Employee objects.
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Using the First constructor.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        susan.DisplayEmployeeInfo();
       
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Using the Second constructor.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        mark.DisplayEmployeeInfo();
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Using the Third constructor.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        joy.DisplayEmployeeInfo();
        
        Console.ForegroundColor = ConsoleColor.White;

    }
}