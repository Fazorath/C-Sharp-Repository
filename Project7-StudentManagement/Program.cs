using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
// Todo Retrieve all function orderby by ID number 

namespace Project7_StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // list of Student objects
            List<Student> students = new List<Student>
            {
                new Student(1, "Yoenis", "Hernandez", 20),
                new Student(2, "Yannah", "Blaise", 65),
                new Student(3, "Boopity", "Scoop", 65),
                new Student(4, "Brandon", "Goat", 21),
                new Student(5, "Hello", "Mister", 45),
            };

            void Menu()
            {
                // Reusing Menu function from previous projects
                bool exit = false;
                while (!exit)
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
                            // GetstudentDetails returns an object which is assigned to added students for AddStudent to take as parameter
                            var AddedStudent = StudentFunctions.GetStudentDetails();
                            StudentFunctions.AddStudent(students, AddedStudent);
                            break;
                        case "2":
                            Clear();
                            StudentFunctions.allStudents(students);
                            break;
                        case "3":
                            Clear();
                            StudentFunctions.DisplayStudentsOrderedByFirstName(students);
                            break;
                        case "4":
                            Clear();
                            StudentFunctions.DisplayStudentOrderedByLastName(students);
                            break;
                        case "5":
                            Clear();
                            StudentFunctions.DisplayStudentOrderedByAge(students);   
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
            
            Menu();
        }
    }
}
