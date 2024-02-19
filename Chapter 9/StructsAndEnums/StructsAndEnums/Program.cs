using System;

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Month first = Month.December;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);


        }

        static void Main()
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
}
