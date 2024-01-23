



namespace LearningMethods
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void testing(int number) 
        { 
            // random number gen
            Random numbergen = new Random();

            string name = "X-" + numbergen.Next(10, 99999);
            int age = numbergen.Next(10,250);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine("- - - - - - - - - ");
        }
    }
}
