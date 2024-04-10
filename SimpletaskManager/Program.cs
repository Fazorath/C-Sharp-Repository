using SimpleTaskManager;
using System.Runtime.CompilerServices;
using static System.Console;
CustomTask task1 = new CustomTask("Task 1", "Description for Task 1", TimeSpan.FromHours(2), false);
void menu()
{
    bool exit = false;
    while (exit != true)
    {
        WriteLine("""
            ░█▀▀░▀█▀░█▄█░█▀█░█░░░█▀▀░▀█▀░█▀▀░█░█░▀█▀░█▄█░█▀█░█▀█░█▀█░█▀▀░█▀▀░█▀▄
            ░▀▀█░░█░░█░█░█▀▀░█░░░█▀▀░░█░░█▀▀░▄▀▄░░█░░█░█░█▀█░█░█░█▀█░█░█░█▀▀░█▀▄
            ░▀▀▀░▀▀▀░▀░▀░▀░░░▀▀▀░▀▀▀░░▀░░▀▀▀░▀░▀░░▀░░▀░▀░▀░▀░▀░▀░▀░▀░▀▀▀░▀▀▀░▀░▀

            Menu Items
            1. Add a New Task
            2.List All Tasks
            3.Mark a task as Completed
            4.Delete a Task
            5.Exit the Application
            """);
        int choice = 0;
        Write("\nEnter your Choice: ");
        string userInput = ReadLine();
        
    }
}

menu();