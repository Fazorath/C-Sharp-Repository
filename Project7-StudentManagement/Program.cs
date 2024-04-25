using System;
using System.Collections.Generic;
using System.Linq;

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
                new Student(2, "Yannah", "Blaise", 22),
                new Student(4, "Brandon", "Goat", 21),
                new Student(5, "Hello", "Mister", 21),
                new Student(6, "World", "March", 21),
                new Student(7, "Eggs", "Benedict", 21),
                // Add more students as needed
            };
        }
    }
}
