// Yoenis Hernandez
// 04/08/2024
// Simple task manager
using SimpleTaskManager;
using static System.Console;
class Program
{
    static TaskManager taskManager = new TaskManager();
    static void Main(string[] args)
    {
        // Calls the main menu function
        Menu();
    }
    static void Menu()
    {
        // Exit Variable with While loop
        bool exit = false;
        while (!exit)
        {
            // Title that appears aswell as a switch case statement based on user input
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
                Write("\nEnter your Choice: "); ForegroundColor = ConsoleColor.Red; string userInput = ReadLine();
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
    static void AddTask()
    {
        // What is called when user presser 1 in the main menu Asks for all of the args needed for our customtask class
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
        // Checking to see if the DateTime was inputted correcly, if so continue
        if (DateTime.TryParse(ReadLine(), out DateTime dueDate))
        {
            // initializes a new task from the class and calls the add task function from the taskmanager class
            CustomTask newTask = new CustomTask(title, description, dueDate, false);
            // function to insert into collections list
            taskManager.AddTask(newTask);
            Clear();
            Write("Task added successfully.\n" + "Press Enter to move on!");
            ReadKey();
            Clear();
        }
        else
        {
            Clear();
            WriteLine("Invalid date format. Task not added.\nPress <Enter> to move on");
            ReadKey();
            Clear();
        }
    }
    static void MarkTaskAsCompleted()
    {
        // Function called when user presses 3 and that collects the index position to be used by the taskmanager class
        Write("Enter the index of the task to mark as completed: ");
        ForegroundColor = ConsoleColor.Green;
        if (int.TryParse(ReadLine(), out int index))
        {
            // function that marks the indexed task as completed and updates list
            taskManager.MarkTaskAsCompleted(index);
        }
        else
        {
            WriteLine("Invalid input. Please enter a valid index.");
        }
    }
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
                WriteLine("\nInvalid input. Please enter a valid index or 'cancel' to go back.");
            }
        }
    }
}