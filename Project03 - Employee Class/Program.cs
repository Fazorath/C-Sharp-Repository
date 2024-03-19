<<<<<<< HEAD
﻿/*
Create an application with a class named Employee.The Employee class should have the following fields:

name - the employee name
idNumber - the employee IdNumber 
department  the department the employee works for
position - the employee's job title
The class should have the following overloaded constructors:

A constructor that accepts the following values as arguments and assigns them to the appropriate fields: employee's name, employee's ID number, department, and position.
A constructor that accepts the following values as arguments and assigns them to the appropriate fields: employee's name and ID number, the department and position should be assigned an empty string "".
A parameterless constructor that assigns empty strings "" to the name, idNumber, department and position fields.
In an application, create three Employee objects to hold the following data:
*/

class Employee
{
    
    public string name;
    public int idNumber;
    public string department;
    public string position;
    
    public Employee(string name, int idNumber, string department, string position)
    {
        this.name = name;
        this.idNumber = idNumber;
        this.department = department;
        this.position = position;
    }

    static void Main(string[] args)
    {
        Employee John = new Employee("John", 05456, "Aids", "Manager");
        Console.WriteLine(John.position);
    }
    
}
=======
﻿using System;
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
>>>>>>> 63c0beaca0d5042310d28f739f20d811a6867dc0
