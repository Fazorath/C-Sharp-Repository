/*
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
