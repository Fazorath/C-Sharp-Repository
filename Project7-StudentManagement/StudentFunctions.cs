using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Project7_StudentManagement
{
    public class StudentFunctions
    {
        public static void allStudents(List<Student> students)
        {
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("""
                    
                     ██▓     ██▓ ███▄    █   █████       ██████ ▓██   ██▓  ██████ ▄▄▄█████▓▓█████  ███▄ ▄███▓
                    ▓██▒    ▓██▒ ██ ▀█   █ ▒██▓  ██▒   ▒██    ▒  ▒██  ██▒▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██▒▀█▀ ██▒
                    ▒██░    ▒██▒▓██  ▀█ ██▒▒██▒  ██░   ░ ▓██▄     ▒██ ██░░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██    ▓██░
                    ▒██░    ░██░▓██▒  ▐▌██▒░██  █▀ ░     ▒   ██▒  ░ ▐██▓░  ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██    ▒██ 
                    ░██████▒░██░▒██░   ▓██░░▒███▒█▄    ▒██████▒▒  ░ ██▒▓░▒██████▒▒  ▒██▒ ░ ░▒████▒▒██▒   ░██▒
                    ░ ▒░▓  ░░▓  ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒    ▒ ▒▓▒ ▒ ░   ██▒▒▒ ▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒░   ░  ░
                    ░ ░ ▒  ░ ▒ ░░ ░░   ░ ▒░ ░ ▒░  ░    ░ ░▒  ░ ░ ▓██ ░▒░ ░ ░▒  ░ ░    ░     ░ ░  ░░  ░      ░
                      ░ ░    ▒ ░   ░   ░ ░    ░   ░    ░  ░  ░   ▒ ▒ ░░  ░  ░  ░    ░         ░   ░      ░   
                        ░  ░ ░           ░     ░             ░   ░ ░           ░              ░  ░       ░   
                    
                        Retrieving All Students!  

                    """);
            ForegroundColor = ConsoleColor.Green;
            // simple LINQ using Order by
            foreach (Student student in students)
            {
                WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}, Age: {student.Age}");
            }
            ForegroundColor = ConsoleColor.Magenta;
            Write("\nPress Enter to move on!");
            ReadKey();
            Clear();
        }
        // Function to display students ordered by alphabetical first name
        public static void DisplayStudentsOrderedByFirstName(List<Student> students)
        {
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("""
                   
                    ██▓     ██▓ ███▄    █   █████       ██████ ▓██   ██▓  ██████ ▄▄▄█████▓▓█████  ███▄ ▄███▓
                   ▓██▒    ▓██▒ ██ ▀█   █ ▒██▓  ██▒   ▒██    ▒  ▒██  ██▒▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██▒▀█▀ ██▒
                   ▒██░    ▒██▒▓██  ▀█ ██▒▒██▒  ██░   ░ ▓██▄     ▒██ ██░░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██    ▓██░
                   ▒██░    ░██░▓██▒  ▐▌██▒░██  █▀ ░     ▒   ██▒  ░ ▐██▓░  ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██    ▒██ 
                   ░██████▒░██░▒██░   ▓██░░▒███▒█▄    ▒██████▒▒  ░ ██▒▓░▒██████▒▒  ▒██▒ ░ ░▒████▒▒██▒   ░██▒
                   ░ ▒░▓  ░░▓  ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒    ▒ ▒▓▒ ▒ ░   ██▒▒▒ ▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒░   ░  ░
                   ░ ░ ▒  ░ ▒ ░░ ░░   ░ ▒░ ░ ▒░  ░    ░ ░▒  ░ ░ ▓██ ░▒░ ░ ░▒  ░ ░    ░     ░ ░  ░░  ░      ░
                     ░ ░    ▒ ░   ░   ░ ░    ░   ░    ░  ░  ░   ▒ ▒ ░░  ░  ░  ░    ░         ░   ░      ░   
                       ░  ░ ░           ░     ░             ░   ░ ░           ░              ░  ░       ░   
                   
                       Retrieving Student First Names
                       
                   """);
            ForegroundColor = ConsoleColor.Green;
            // Simple LINQ Using orderBy
            var studentsOrderedByFirstName = students.OrderBy(s => s.FirstName);
            foreach (var student in studentsOrderedByFirstName)
            {
                Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
            }
            ForegroundColor = ConsoleColor.Magenta;
            Write("\nPress Enter to move on!");
            ReadKey();
            Clear();
        }
        // Function to Display Student by last name
        public static void DisplayStudentOrderedByLastName(List<Student> students)
        {
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("""
                   
                    ██▓     ██▓ ███▄    █   █████       ██████ ▓██   ██▓  ██████ ▄▄▄█████▓▓█████  ███▄ ▄███▓
                   ▓██▒    ▓██▒ ██ ▀█   █ ▒██▓  ██▒   ▒██    ▒  ▒██  ██▒▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██▒▀█▀ ██▒
                   ▒██░    ▒██▒▓██  ▀█ ██▒▒██▒  ██░   ░ ▓██▄     ▒██ ██░░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██    ▓██░
                   ▒██░    ░██░▓██▒  ▐▌██▒░██  █▀ ░     ▒   ██▒  ░ ▐██▓░  ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██    ▒██ 
                   ░██████▒░██░▒██░   ▓██░░▒███▒█▄    ▒██████▒▒  ░ ██▒▓░▒██████▒▒  ▒██▒ ░ ░▒████▒▒██▒   ░██▒
                   ░ ▒░▓  ░░▓  ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒    ▒ ▒▓▒ ▒ ░   ██▒▒▒ ▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒░   ░  ░
                   ░ ░ ▒  ░ ▒ ░░ ░░   ░ ▒░ ░ ▒░  ░    ░ ░▒  ░ ░ ▓██ ░▒░ ░ ░▒  ░ ░    ░     ░ ░  ░░  ░      ░
                     ░ ░    ▒ ░   ░   ░ ░    ░   ░    ░  ░  ░   ▒ ▒ ░░  ░  ░  ░    ░         ░   ░      ░   
                       ░  ░ ░           ░     ░             ░   ░ ░           ░              ░  ░       ░   
                   
                       Retrieving Student Last Names
                       
                   """);
            ForegroundColor = ConsoleColor.Green;
            // Simple LINQ using OrderBy
            var studentOrderedByLastName = students.OrderBy(s => s.LastName);
            foreach (var student in studentOrderedByLastName)
            {
                Console.WriteLine($"Name: {student.LastName} {student.FirstName}");
            }
            ForegroundColor = ConsoleColor.Magenta;
            Write("\nPress Enter to move on!");
            ReadKey();
            Clear();
        }
        // Function to display Student by Age
        public static void DisplayStudentOrderedByAge(List<Student> students)
        {
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("""
                   
                    ██▓     ██▓ ███▄    █   █████       ██████ ▓██   ██▓  ██████ ▄▄▄█████▓▓█████  ███▄ ▄███▓
                   ▓██▒    ▓██▒ ██ ▀█   █ ▒██▓  ██▒   ▒██    ▒  ▒██  ██▒▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██▒▀█▀ ██▒
                   ▒██░    ▒██▒▓██  ▀█ ██▒▒██▒  ██░   ░ ▓██▄     ▒██ ██░░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██    ▓██░
                   ▒██░    ░██░▓██▒  ▐▌██▒░██  █▀ ░     ▒   ██▒  ░ ▐██▓░  ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██    ▒██ 
                   ░██████▒░██░▒██░   ▓██░░▒███▒█▄    ▒██████▒▒  ░ ██▒▓░▒██████▒▒  ▒██▒ ░ ░▒████▒▒██▒   ░██▒
                   ░ ▒░▓  ░░▓  ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒    ▒ ▒▓▒ ▒ ░   ██▒▒▒ ▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒░   ░  ░
                   ░ ░ ▒  ░ ▒ ░░ ░░   ░ ▒░ ░ ▒░  ░    ░ ░▒  ░ ░ ▓██ ░▒░ ░ ░▒  ░ ░    ░     ░ ░  ░░  ░      ░
                     ░ ░    ▒ ░   ░   ░ ░    ░   ░    ░  ░  ░   ▒ ▒ ░░  ░  ░  ░    ░         ░   ░      ░   
                       ░  ░ ░           ░     ░             ░   ░ ░           ░              ░  ░       ░   
                   
                       Retrieving Students Between the ages of 18 and 30
                       
                   """);
            ForegroundColor = ConsoleColor.Green;
            // LINQ using .Where and OrderBy
            var orderedStudents = students
                                .Where(s => s.Age >= 18 && s.Age <= 30)
            .OrderBy(s => s.Age);
            // Loop to Display whatever is inside Var
            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}, Age: {student.Age}");
            }
            ForegroundColor = ConsoleColor.Magenta;
            Write("\nPress Enter to move on!");
            ReadKey();
            Clear();
        }
        // Function to ask for student details and return a Student object
        public static Student GetStudentDetails()
        {
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("""
                   
                    ██▓     ██▓ ███▄    █   █████       ██████ ▓██   ██▓  ██████ ▄▄▄█████▓▓█████  ███▄ ▄███▓
                   ▓██▒    ▓██▒ ██ ▀█   █ ▒██▓  ██▒   ▒██    ▒  ▒██  ██▒▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██▒▀█▀ ██▒
                   ▒██░    ▒██▒▓██  ▀█ ██▒▒██▒  ██░   ░ ▓██▄     ▒██ ██░░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██    ▓██░
                   ▒██░    ░██░▓██▒  ▐▌██▒░██  █▀ ░     ▒   ██▒  ░ ▐██▓░  ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██    ▒██ 
                   ░██████▒░██░▒██░   ▓██░░▒███▒█▄    ▒██████▒▒  ░ ██▒▓░▒██████▒▒  ▒██▒ ░ ░▒████▒▒██▒   ░██▒
                   ░ ▒░▓  ░░▓  ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒    ▒ ▒▓▒ ▒ ░   ██▒▒▒ ▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒░   ░  ░
                   ░ ░ ▒  ░ ▒ ░░ ░░   ░ ▒░ ░ ▒░  ░    ░ ░▒  ░ ░ ▓██ ░▒░ ░ ░▒  ░ ░    ░     ░ ░  ░░  ░      ░
                     ░ ░    ▒ ░   ░   ░ ░    ░   ░    ░  ░  ░   ▒ ▒ ░░  ░  ░  ░    ░         ░   ░      ░   
                       ░  ░ ░           ░     ░             ░   ░ ░           ░              ░  ░       ░   
                   
                       Retrieving Students Between the ages of 18 and 30
                       
                   """);
            Console.WriteLine("Enter student details:");
            Console.Write("Student ID: ");
            ForegroundColor = ConsoleColor.Green;
            int studentId = int.Parse(Console.ReadLine());

            ForegroundColor = ConsoleColor.Magenta;
            Console.Write("First Name: ");
            ForegroundColor = ConsoleColor.Green;
            string firstName = Console.ReadLine();

            ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Last Name: ");
            ForegroundColor = ConsoleColor.Green;
            string lastName = Console.ReadLine();

            ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Age: ");
            ForegroundColor = ConsoleColor.Green;
            int age = int.Parse(Console.ReadLine());

            // Create a new Student object with the provided details
            Student newStudent = new Student(studentId, firstName, lastName, age);
            return newStudent;
        }

        // Function to add a student to the list
        public static void AddStudent(List<Student> students, Student student)
        {
            // Add the new student to the list
            students.Add(student);
            WriteLine($"Student {student.FirstName} {student.LastName} added successfully!");
            ForegroundColor = ConsoleColor.Magenta;
            Write("\nPress Enter to move on!");
            ReadKey();
            Clear();
        }
    }
}
