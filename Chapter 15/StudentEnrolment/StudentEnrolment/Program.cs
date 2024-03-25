using System;

namespace StudentEnrolment
{
    class Program
    {
        static void doWork()
        {
            var Enrollments = new Enrollment[4];
            Enrollments[0] = new Enrollment(StudentID: 1, CourseName:
            "Physics",
            DateEnrolled: new DateOnly(2021, 07, 20));
            Enrollments[1] = new Enrollment(StudentID: 1, CourseName:
            "Chemistry",
            DateEnrolled: new DateOnly(2021, 07, 20));
            Enrollments[2] = Enrollments[0];
            Enrollments[3] = Enrollments[0] with { StudentID = 2 };
            foreach (var Enrollment in Enrollments)
            {
                Console.WriteLine($"{Enrollment}");
            }
            var firstEnrollment = Enrollments[0];
            foreach (var Enrollment in Enrollments[1..4])
            {
                Console.WriteLine($"{firstEnrollment == Enrollment}");
            }



        }
    }


    static void Main(string[] args)
    {
        try
        {
            doWork();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

