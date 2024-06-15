using System;
using UserAuthProject.Services;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Register a new user");
            Console.Write("Enter your email: ");
            var email = Console.ReadLine();

            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            UserService.RegisterUser(email, password);

            Console.WriteLine("User registered successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}