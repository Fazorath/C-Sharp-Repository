using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project7_StudentManagement
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(int studentId, string firstName, string lastName, int age)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
