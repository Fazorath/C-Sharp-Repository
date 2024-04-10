using System;
using static System.Console;
namespace SimpleTaskManager
{
    public class TaskManager
    {
        private readonly List<CustomTask> tasks;
        public TaskManager()
        {
            // Initializes a new list called tasks for generic collection
            tasks = [];
        }
        public void AddTask(CustomTask task)
        {
            // uses the passed information from previous function to add class to list.
            tasks.Add(task);
        }
        public void ListTasks()
        {
            // Function to list all the tasks using a for loop to iterate
            WriteLine("All Tasks:");
            ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < tasks.Count; i++)
            {
                WriteLine($"\n[{i}] {tasks[i]}");
                WriteLine("-----------------------");
            }
            ForegroundColor = ConsoleColor.Red;
            Write("\nPress Enter to move on!");
            ReadKey();
            Clear();
        }
        public void MarkTaskAsCompleted(int index)
        // Marks a task as completed based on its index.
        {
            // using the index passed to mark as complete
            if (index >= 0 && index < tasks.Count)
            {
                // using index position to change boolean value from task class specifically to change that one task !!!
                tasks[index].IsCompleted = true;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\nTask marked as completed.");
            }
            else
            {
                Clear();
                WriteLine("\nInvalid task index.");
            }
            Write("Press Enter to move on!");
            ReadKey();
            Clear();
        }
        public void DeleteTask(int index)
        // Deletes a task from the TaskManager based on its index.
        {
            // Using the index position passed it checks and deletes if available
            if (index >= 0 && index < tasks.Count)
            {
                // removes from the task generic collections list if at proper index
                tasks.RemoveAt(index);
                WriteLine("\nTask deleted.");
            }
            else
            {
                Clear();
                WriteLine("\nInvalid task index.");
            }
            Write("Press Enter to move on!");
            ReadKey();
            Clear();
        }
    }
}