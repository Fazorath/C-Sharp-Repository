using SimpleTaskManager;
using System;
using static System.Console;

class Program
{
    static TaskManager taskManager = new TaskManager();

    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        bool exit = false;
        while (!exit)
        {
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

            Write("\nEnter your Choice: ");
            ForegroundColor = ConsoleColor.Red;
            string userInput = ReadLine();

            switch (userInput)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    WriteLine("Listing all tasks.");
                    taskManager.ListTasks();
                    break;
                case "3":
                    WriteLine("Marking a task as completed.");
                    MarkTaskAsCompleted();
                    break;
                case "4":
                    WriteLine("Deleting a task.");
                    DeleteTask();
                    break;
                case "5":
                    WriteLine("Exiting the program.");
                    exit = true;
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }

        }
    }

    static void AddTask()
    {
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
        if (DateTime.TryParse(ReadLine(), out DateTime dueDate))
        {
            CustomTask newTask = new CustomTask(title, description, dueDate, false);
            taskManager.AddTask(newTask);
            Clear();
            WriteLine("Task added successfully.\n" +
                "Press Enter to move on!\n");
            ReadKey();
            Clear();
        }
        else
        {
            WriteLine("Invalid date format. Task not added.");
        }
    }

    static void MarkTaskAsCompleted()
    {
        Write("Enter the index of the task to mark as completed: ");
        if (int.TryParse(ReadLine(), out int index))
        {
            taskManager.MarkTaskAsCompleted(index);
        }
        else
        {
            WriteLine("Invalid input. Please enter a valid index.");
        }
    }

    static void DeleteTask()
    {
        Write("Enter the index of the task to delete: ");
        if (int.TryParse(ReadLine(), out int index))
        {
            taskManager.DeleteTask(index);
        }
        else
        {
            WriteLine("Invalid input. Please enter a valid index.");
        }
    }
}
