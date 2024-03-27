// Yoenis Hernandez
// Project 5 Using interfaces and linking it to a class.
// 3-25-24
using System;
using System.Security.AccessControl;
using static System.Net.WebRequestMethods;

class Program
{
    static void Main(string[] args)
    {
        // bool for the menu
        bool exit = false;
        while (!exit)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CUSTOMER INTERFACE");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("1. Preferred Customer");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            Console.ForegroundColor= ConsoleColor.Red;
            // Read user input
            string input = Console.ReadLine();
            Console.Clear();

            // Validate and process user input using tweaked function from stack
            // https://stackoverflow.com/questions/17766306/a-method-with-tryparse-using-min-and-max-limits
            
            if (IsValidInput(input, 1, 3))
            {
                int option = int.Parse(input);
                // I LOVE SWITCHCASES
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nPreferred Customer selected.\n");
                        HandlePreferredCustomer();
                        break;
                    case 2:
                        Console.WriteLine("\nCustomer selected.\n");
                        Customer customer = GetCustomerDetails();
                        Console.Clear();
                        Console.WriteLine("\nCustomer Information:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(customer); // Uses ToString() implicitly
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program.");
                        Console.ForegroundColor=ConsoleColor.White;
                        exit = true;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }

            Console.WriteLine(); // Empty line for readability
        }
    }


    static bool IsValidInput(string input, int min, int max)
    {
        // Function to validate user input
        return int.TryParse(input, out int result) && result >= min && result <= max;
    }
    static PreferredCustomer PreferredCustomer()
    {
        // used to initialized new class that is used for discount purposes
        PreferredCustomer preferredCustomer = new PreferredCustomer();
        return preferredCustomer;
    }
    static void HandlePreferredCustomer()
    {
        PreferredCustomer preferredCustomer = PreferredCustomer();
        Console.ForegroundColor=ConsoleColor.Green;
        Console.Write("Enter Purchase Amount: ");
        Console.ForegroundColor = ConsoleColor.Red;
        double purchaseAmount = double.Parse(Console.ReadLine());

        // Assign purchase amount and calculate discount
        preferredCustomer.PurchaseAmount = purchaseAmount;
        
        // function for finding out the proper discount amount
        preferredCustomer.SetDiscountLevel();

        // Format the discount percentage without trailing zeros
        string discountText = $"{preferredCustomer.DiscountLevel * 100:0.##}%";


        // Display purchase information only for Option 1
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPurchase Information:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Initial Purchase Amount: ${purchaseAmount}");
        Console.WriteLine($"Discount: {discountText}");
        Console.WriteLine($"Updated Discounted Amount: ${purchaseAmount - (purchaseAmount * preferredCustomer.DiscountLevel)}");
    }
    static Customer GetCustomerDetails()
    {
        // all of the Customer details that are going to be presented in the 2nd menu option
        Customer customer = new Customer();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter Customer Number: ");
        Console.ForegroundColor= ConsoleColor.Red;
        customer.CustomerNumber = int.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter First Name: ");
        Console.ForegroundColor = ConsoleColor.Red;
        customer.FirstName = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter Last Name: ");
        Console.ForegroundColor = ConsoleColor.Red;
        customer.LastName = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter City: ");
        Console.ForegroundColor = ConsoleColor.Red;
        customer.City = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter State: ");
        Console.ForegroundColor = ConsoleColor.Red;
        customer.State = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter Zip Code: ");
        Console.ForegroundColor = ConsoleColor.Red;
        customer.ZipCode = Console.ReadLine();

        return customer;
    }

}
