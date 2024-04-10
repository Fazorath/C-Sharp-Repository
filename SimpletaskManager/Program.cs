using SimpleTaskManager;
using System;

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
            Console.WriteLine(@"
            ░█▀▀░▀█▀░█▄█░█▀█░█░░░█▀▀░▀█▀░█▀▀░█░█░▀█▀░█▄█░█▀█░█▀█░█▀█░█▀▀░█▀▀░█▀▄
            ░▀▀█░░█░░█░█░█▀▀░█░░░█▀▀░░█░░█▀▀░▄▀▄░░█░░█░█░█▀█░█░█░█▀█░█░█░█▀▀░█▀▄
            ░▀▀▀░▀▀▀░▀░▀░▀░░░▀▀▀░▀▀▀░░▀░░▀▀▀░▀░▀░░▀░░▀░▀░▀░▀░▀░▀░▀░▀▀▀░▀▀▀░▀░▀

            Menu Items
            1. Add a New Task
            2. List All Tasks
            3. Mark a Task as Completed
            4. Delete a Task
            5. Exit the Application
            ");

            Console.Write("\nEnter your Choice: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Adding a new task.");
                    AddTask();
                    break;
                case "2":
                    Console.WriteLine("Listing all tasks.");
                    taskManager.ListTasks();
                    break;
                case "3":
                    Console.WriteLine("Marking a task as completed.");
                    MarkTaskAsCompleted();
                    break;
                case "4":
                    Console.WriteLine("Deleting a task.");
                    DeleteTask();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program.");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }

            Console.WriteLine("---------------------------------------");
        }
    }

    static void AddTask()
    {
        Console.Write("Enter Task Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Task Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Task Due Date (MM/dd/yyyy): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
        {
            CustomTask newTask = new CustomTask(title, description, dueDate, false);
            taskManager.AddTask(newTask);
            Console.WriteLine("Task added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid date format. Task not added.");
        }
    }

    static void MarkTaskAsCompleted()
    {
        Console.Write("Enter the index of the task to mark as completed: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            taskManager.MarkTaskAsCompleted(index);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid index.");
        }
    }

    static void DeleteTask()
    {
        Console.Write("Enter the index of the task to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            taskManager.DeleteTask(index);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid index.");
        }
    }
}
