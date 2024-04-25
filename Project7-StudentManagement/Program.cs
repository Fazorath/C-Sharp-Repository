using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;


namespace Project7_StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Student objects
            List<Student> students = new List<Student>
            {
                new Student(1, "Yoenis", "Hernandez", 20),
                new Student(2, "Yannah", "Blaise", 65),
                new Student(4, "Brandon", "Goat", 21),
                new Student(5, "Hello", "Mister", 45),
                new Student(6, "World", "March", 21),
                new Student(7, "Eggs", "Benedict", 79),
                // Add more students as needed
            };

            void Menu()
            {
                // Reusing Menu function from previous projects
                bool exit = false;
                while (!exit)
                {
                    // Displaying the menu
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
                  
                Menu Items

            1. Add New Student to Collection
            2. Retrieve All Students
            3. Retrieve All Students by Alphabetical First Name
            4. Retrieve All Students by Alphabetical Last Name
            5. Retrieve All Students between the ages of 18 and 30
            6. Quit
            """);

                    // Getting user input for menu choice
                    Write("\nEnter your Choice: ");
                    ForegroundColor = ConsoleColor.Green;
                    string userInput = ReadLine();

                    // Switch case based on user input
                    switch (userInput)
                    {
                        case "1":
                            Clear();
                            break;
                        case "2":
                            Clear();
                            allStudents(students);
                            break;
                        case "3":
                            Clear();
                            DisplayStudentsOrderedByFirstName(students);
                            break;
                        case "4":
                            Clear();
                            DisplayStudentOrderedByLastName(students);
                            break;
                        case "5":
                            Clear();
                            DisplayStudentOrderedByAge(students);   
                            break;
                        case "6":
                            Clear();
                            WriteLine("Exiting the program.");
                            exit = true;
                            break;
                        default:
                            Clear();
                            WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
            }
            void allStudents(List<Student> students)
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
                foreach (Student student in students)
                {
                    WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}, Age: {student.Age}");
                }
                ForegroundColor = ConsoleColor.Magenta;
                Write("\nPress Enter to move on!");
                ReadKey();
                Clear();
            };
            // Function to display students ordered by alphabetical first name
            static void DisplayStudentsOrderedByFirstName(List<Student> students)
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

            static void DisplayStudentOrderedByLastName(List<Student> students)
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
                var studentOrderedByLastName = students.OrderBy(s => s.LastName);
                foreach(var student in studentOrderedByLastName)
                {
                    Console.WriteLine($"Name: {student.LastName} {student.FirstName}");
                }
                ForegroundColor = ConsoleColor.Magenta;
                Write("\nPress Enter to move on!");
                ReadKey();
                Clear();
            }
            static void DisplayStudentOrderedByAge(List<Student> students)
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
                var orderedStudents = students
                                    .Where(s => s.Age >= 18 && s.Age <= 30)
                .OrderBy(s => s.Age);
                foreach (var student in orderedStudents)
                {
                    Console.WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}, Age: {student.Age}");
                }
                ForegroundColor = ConsoleColor.Magenta;
                Write("\nPress Enter to move on!");
                ReadKey();
                Clear();
            }

            Menu();
        }
    }
}
