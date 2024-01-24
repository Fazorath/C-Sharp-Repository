using System;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double fee = calculateFee(theDailyRate: 375.0);
            Console.WriteLine($"fee is {fee}");
        }


        private double calculateFee(double theDailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("Calculate using two optional Parameters");
            return theDailyRate * noOfDays;
        }


        private double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("Calculate using one optional Parameters");
            int defaultNoofDays = 1;
            return dailyRate * defaultNoofDays;
        }


        private double calculateFee()
        {
            Console.WriteLine("Calculate using Hardcoded Values");
            double defaultDailyRate = 400.0;
            int defaultNoOfDays = 1;
            return defaultDailyRate * defaultNoOfDays;

        }
    }
}
