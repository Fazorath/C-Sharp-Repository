// Yoenis Hernandez
// 
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // both files that need to be open a bool to determine menu
        bool exitprogram = false;
        float[] salesData = ReadSalesFromFile("Sales.txt");
        int[] chargeAccounts = ReadChargeAccountsFromFile("ChargeAccounts.txt");


        while (!exitprogram)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // Display the main menu
            Console.WriteLine("Main Menu\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Sales Section");
            Console.WriteLine("2. Charge Account Section");
            Console.WriteLine("3. Exit");
            Console.Write("\nEnter your choice: ");

            // Get user input
            string userInput = Console.ReadLine();

            // Handle user input using the learned switch case
            switch (userInput)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSALES SECTION");
                    SalesSubMenu(ref salesData);
                    // Add code for Sales Section
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nCHARGE SECTION");
                    ChargeAccountsSubMenu(ref chargeAccounts);
                    // Add code for Charge Account Section
                    break;
                case "3":
                    Console.WriteLine("Exiting the program...");
                    exitprogram = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option (1, 2, or 3).");
                    break;
            }

            // Add some space for readability
            Console.WriteLine();
        }
    }
    static void SalesSubMenu(ref float[] salesData)
    {
        // Sales sub menu function to display the submenu
        bool backToMainMenu = false;

        while (!backToMainMenu)
        {
            // Display the Sales Submenu
            Console.WriteLine("1. Add New Entry");
            Console.WriteLine("2. Calculate Average");
            Console.WriteLine("3. Find Largest Value");
            Console.WriteLine("4. Find Smallest Value");
            Console.WriteLine("5. Return to Main Menu");


            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write("\nEnter your choice: ");

            // Get user input
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddNewEntry(ref salesData);
                    break;
                case "2":
                    CalculateAverage(salesData);
                    break;
                case "3":
                    FindLargestValue(salesData);
                    break;
                case "4":
                    FindSmallestValue(salesData);
                    break;
                case "5":
                    backToMainMenu = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option (1-5).");
                    break;
            }

            // Add some space for readability
            Console.WriteLine();
        }
    }
    static void AddNewEntry(ref float[] salesData)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write("Enter the new sales value: ");
        if (float.TryParse(Console.ReadLine(), out float newValue))
        {
            // Add the new value to the array
            Array.Resize(ref salesData, salesData.Length + 1);
            salesData[salesData.Length - 1] = newValue;

            // Write the updated array to the file
            File.WriteAllLines("Sales.txt", salesData.Select(d => d.ToString()));

            Console.WriteLine("New entry added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    static void CalculateAverage(float[] salesData)
    {
        if (salesData.Length == 0)
        {
            Console.WriteLine("No sales data available.");
            return;
        }

        double average = salesData.Average();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nAverage of sales data: {average:F2}");
    }
    static void FindLargestValue(float[] salesData)
    {
        if (salesData.Length == 0)
        {
        
            Console.WriteLine("\nNo sales data available.");
            return;
        }

        float largestValue = salesData.Max();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nLargest value in sales data: {largestValue}");
    }
    static void FindSmallestValue(float[] salesData)
    {
        if (salesData.Length == 0)
        {
            Console.WriteLine("No sales data available.");
            return;
        }

        float smallestValue = salesData.Min();
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"\nSmallest value in sales data: {smallestValue}");
    }
    static float[] ReadSalesFromFile(string filename)
    {
        float[] salesData;
        if (File.Exists(filename))
        {
            // Read data from the file
            string[] lines = File.ReadAllLines(filename);

            // Convert lines to float numbers
            salesData = new float[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                if (float.TryParse(lines[i], out float value))
                {
                    salesData[i] = value;
                }
                else
                {
                    Console.WriteLine($"Invalid data found in file at line {i + 1}. Skipping...");
                }
            }
        }
        else
        {
            // If file doesn't exist, create an empty array
            salesData = new float[0];
        }

        return salesData;
    }

    static void ChargeAccountsSubMenu(ref int[] chargeAccounts)
    {
        bool backToMainMenu = false;

        while (!backToMainMenu)
        {
            // Display the Charge Accounts Submenu
            Console.WriteLine("1. Verify Charge Account Number");
            Console.WriteLine("2. Add New Charge Account Number");
            Console.WriteLine("3. Return to Main Menu");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEnter your choice: ");

            // Get user input
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    VerifyChargeAccount(ref chargeAccounts);
                    break;
                case "2":
                    AddNewChargeAccount(ref chargeAccounts);
                    break;
                case "3":
                    backToMainMenu = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option (1-3).");
                    break;
            }

            // Add some space for readability
            Console.WriteLine();
        }
    }
    static void VerifyChargeAccount(ref int[] chargeAccounts)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\nEnter a 7-digit charge account number: ");
        string input = Console.ReadLine();

        if (input.Length != 7)
        {
            Console.WriteLine("Invalid length. Charge account numbers must be 7 digits long.");
            return;
        }

        if (!int.TryParse(input, out int accountNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid 7-digit number.");
            return;
        }

        if (chargeAccounts.Contains(accountNumber))
        {
            Console.WriteLine("Valid charge account number.");
        }
        else
        {
            Console.WriteLine("Invalid charge account number.");
        }
    }
    static void AddNewChargeAccount(ref int[] chargeAccounts)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\nEnter a new 7-digit charge account number: ");
        string input = Console.ReadLine();

        if (input.Length != 7)
        {
            Console.WriteLine("Invalid length. Charge account numbers must be 7 digits long.");
            return;
        }

        if (!int.TryParse(input, out int newAccount))
        {
            Console.WriteLine("Invalid input. Please enter a valid 7-digit number.");
            return;
        }

        if (chargeAccounts.Contains(newAccount))
        {
            Console.WriteLine("Account number already exists.");
            return;
        }

        // Add the new account number to the array
        Array.Resize(ref chargeAccounts, chargeAccounts.Length + 1);
        chargeAccounts[chargeAccounts.Length - 1] = newAccount;

        // Write the updated array to the file
        File.WriteAllLines("ChargeAccounts.txt", chargeAccounts.Select(d => d.ToString()));

        Console.WriteLine("New charge account added successfully.");
    }
    static int[] ReadChargeAccountsFromFile(string filename)
    {
        int[] chargeAccounts;
        if (File.Exists(filename))
        {
            // Read data from the file
            string[] lines = File.ReadAllLines(filename);

            // Convert lines to integers
            chargeAccounts = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                if (int.TryParse(lines[i], out int value))
                {
                    chargeAccounts[i] = value;
                }
                else
                {
                    Console.WriteLine($"Invalid data found in file at line {i + 1}. Skipping...");
                }
            }
        }
        else
        {
            // If file doesn't exist, create an empty array
            chargeAccounts = new int[0];
        }

        return chargeAccounts;
    }
    static void SalesSubMenu()
    {
        // Placeholder for Sales Submenu
        Console.WriteLine("Sales Submenu - Placeholder");
    }
}


