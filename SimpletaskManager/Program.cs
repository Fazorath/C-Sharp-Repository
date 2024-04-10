﻿// Importing the SimpleTaskManager namespace and System.Console which i saw on youtube so no longer have to write "Console." infront of everything
using SimpleTaskManager;
using static System.Console;

// Main program class
class Program
{
    // TaskManager instance to manage tasks
    static TaskManager taskManager = new TaskManager();

    // Main method
    static void Main(string[] args)
    {
        // Calls the main menu function
        Menu();
    }

    // Main Menu Function
    static void Menu()
    {
        // Exit Variable with While loop
        bool exit = false;
        while (!exit)
        {
            // Displaying the menu
            ForegroundColor = ConsoleColor.Green;
            WriteLine("""

            ░█▀▀░▀█▀░█▄█░█▀█░█░░░█▀▀░▀█▀░█▀▀░█░█░▀█▀░█▄█░█▀█░█▀█░█▀█░█▀▀░█▀▀░█▀▄
            ░▀▀█░░█░░█░█░█▀▀░█░░░█▀▀░░█░░█▀▀░▄▀▄░░█░░█░█░█▀█░█░█░█▀█░█░█░█▀▀░█▀▄
            ░▀▀▀░▀▀▀░▀░▀░▀░░░▀▀▀░▀▀▀░░▀░░▀▀▀░▀░▀░░▀░░▀░▀░▀░▀░▀░▀░▀░▀░▀▀▀░▀▀▀░▀░▀

            Menu Items
            1. Add a New Task
            2. List All Tasks
            3. Mark a Task as Completed
            4. Delete a Task
            5. Exit the Application
            """);

            // Getting user input for menu choice
            Write("\nEnter your Choice: ");
            ForegroundColor = ConsoleColor.Red;
            string userInput = ReadLine();

            // Switch case based on user input
            switch (userInput)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    Clear();
                    taskManager.ListTasks();
                    break;
                case "3":
                    Clear();
                    WriteLine("\nMarking a task as completed.");
                    MarkTaskAsCompleted();
                    break;
                case "4":
                    Clear();
                    WriteLine("Deleting a task.");
                    DeleteTask();
                    break;
                case "5":
                    Clear();
                    WriteLine("Exiting the program.");
                    exit = true;
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }

    // Function to Add a Task
    static void AddTask()
    {
        // Prompts user for task details
        Clear();
        ForegroundColor = ConsoleColor.Green;
        Write("\nEnter Task Title: ");
        ForegroundColor = ConsoleColor.Red;
        string title = ReadLine();
        ForegroundColor = ConsoleColor.Green;
        Write("Enter Task Description: ");
        ForegroundColor = ConsoleColor.Red;
        string description = ReadLine();
        ForegroundColor = ConsoleColor.Green;
        Write("Enter Task Due Date (MM/DD/YYYY): ");
        ForegroundColor = ConsoleColor.Red;

        // Checking to see if the DateTime was inputted correctly
        if (DateTime.TryParse(ReadLine(), out DateTime dueDate))
        {
            // Creating a new task and adding it to the task manager
            CustomTask newTask = new CustomTask(title, description, dueDate, false);
            taskManager.AddTask(newTask);
            Clear();
            Write("Task added successfully.\nPress Enter to continue");
            ReadKey();
            Clear();
        }
        else
        {
            Clear();
            WriteLine("Invalid date format. Task not added.\nPress Enter to continue");
            ReadKey();
            Clear();
        }
    }

    // Function to Mark a Task as Completed
    static void MarkTaskAsCompleted()
    {
        // Prompts user to enter index of task to mark as completed
        Write("Enter the index of the task to mark as completed: ");
        ForegroundColor = ConsoleColor.Green;

        if (int.TryParse(ReadLine(), out int index))
            // all this does is try to convert my string into an int but fancy from stackoverlow lol
        {
            // Marks the task as completed in the task manager
            taskManager.MarkTaskAsCompleted(index);
        }
        else
        {
            WriteLine("Invalid input. Please enter a valid index.");
        }
    }

    // Function to Delete a Task
    static void DeleteTask()
    {
        // Function called to delete a task from list uses a loop for input handling 
        while (true)
        {
            Console.Write("Enter the index of the task to delete (or 'cancel' to go back): ");
            string input = Console.ReadLine();

            // Format exception try block
            try
            {
                if (input.ToLower() == "cancel")
                {
                    Console.WriteLine("Operation cancelled.");
                    return; // Exit the function
                }

                int index = int.Parse(input);
                // passed the parsed index to deletetask func in taskmanager class incharge of deleting from list
                taskManager.DeleteTask(index);
                return; // Exit the function
            }
            catch (FormatException)
            {
                Clear();
                WriteLine("\nInvalid input. Please enter a valid index or 'cancel' to go back.");
            }
        }
    }
}
